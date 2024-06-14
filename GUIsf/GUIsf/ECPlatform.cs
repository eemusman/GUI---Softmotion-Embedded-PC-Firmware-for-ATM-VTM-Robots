using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMX3ApiCLR;
using WMX3ApiCLR.EcApiCLRLib;

namespace GUIsf
{
    
    class ECPlatform
    {
        public static int[] parameterindices = new int[] {0x3002, 0x3003, 0x3004, 0x3013, 0x3100, 0x3101, 0x3105, 0x3106, 0x3110, 0x3112, 0x3312, 0x3313, 0x3437,0x3438, 0x3521, 0x3522 };
        public static Int16[] defaultparametervalues = new Int16[] { 0x00000000, 0x00000010, 0x000007D0, 0x0000012C, 0x00000384, 0x000001F4, 0x0000041A, 0x000001F4, 0x0000012C, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000001, 0x0000012C };
        private static WMX3Api Wmx3Lib = new WMX3Api();
        private static EcApiLib EcLib = new EcApiLib(Wmx3Lib);
        private static EcMasterInfo MotorInfo = new EcMasterInfo();

        // Register 
        // ---------------------------------- RegSize, Port1 , Port2 , Port3 , Port4,
        //                                             Port5 , Port6 , Port7,  Port8
        Register CrcRxFrmReg = new Register(8, 0x0300, 0x0301, 0x0302, 0x0303,
                                                       0x0304, 0x0305, 0x0306, 0x0307);
        Register FwdRxErrReg = new Register(4, 0x0308, 0x0309, 0x030A, 0x030B);
        Register PUErrReg = new Register(1, 0x030C);
        Register LstLinkErrReg = new Register(4, 0x0310, 0x0311, 0x0312, 0x0313);

        //Hot Connect Logic
        private static bool EndInput=false;
        bool isLost = false;
        bool nowAlive = false;
        bool prevAlive = true;

        public const int sdoBuffSize = 2;                 // [in]  SDO buffer size
        public int slaveId = 0;                 // [in]  Slave ID to download / upload SDO data
        public int index = 0x6080;            // [in]  Index number of SDO
        public int subIndex = 0x0000;            // [in]  Sub index number of SDO

        uint waitTime = 3000;              // [in]  SDO Upload Process timeout time
        public byte[] sdoWriteBuff = new Byte[sdoBuffSize];
        // [in]  SDO write buffer
        public int writeSDOData = 0x1C;              // [in]  Write SDO data.

        uint errorCode = 0;                 // [out] SDO Error code
        uint actualSize = 0;                 // [out] Size of actually uploaded SDO data
        byte[] sdoReadBuff = new Byte[sdoBuffSize];
        // [out] SDO read buffer
        int readSDOData = 0;                 // [out] Read SDO data.

        //Get MasterInfo
        public ECPlatform()
        {
            InitializeFunc();
            EcLib.GetMasterInfo(MotorInfo);
            

        }



        ~ECPlatform()
        {
            FinalizeFunc();
        }
        public void InitializeFunc()
        {
            // Create device.
            Wmx3Lib.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\",
                                 DeviceType.DeviceTypeNormal,
                                 0xFFFFFFFF);

            // Start Communication.
            Wmx3Lib.StartCommunication();

            // Set Device Name.
            Wmx3Lib.SetDeviceName("RwSDO");

        }
        public void FinalizeFunc()
        {
            // Stop Communication.
            //Wmx3Lib.StopCommunication();

            //Quit device.
            //Wmx3Lib.CloseDevice();

        }

        public void CheckCrcAndRxError()
        {

            while (true)
            {

                // --------------------------------------------------------
                // Saves the previous Register.
                // --------------------------------------------------------
                CrcRxFrmReg.SaveCurrentRegister();
                FwdRxErrReg.SaveCurrentRegister();
                PUErrReg.SaveCurrentRegister();
                LstLinkErrReg.SaveCurrentRegister();

                // --------------------------------------------------------
                // Read the data of each Register.
                // --------------------------------------------------------
                ReadRegister(0, CrcRxFrmReg);
                ReadRegister(0, FwdRxErrReg);
                ReadRegister(0, PUErrReg);
                ReadRegister(0, LstLinkErrReg);

                // --------------------------------------------------------
                // It checks whether an error has occurred in each Register.
                // --------------------------------------------------------
                int count = 0;
                if (!EndInput)
                {
                    if (CrcRxFrmReg.IsErrorRegisterIncreasing())
                    {
                        MessageBox.Show("There is CRC or RX Frame error in the network", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        count++;
                    }
                    if (FwdRxErrReg.IsErrorRegisterIncreasing())
                    {
                        MessageBox.Show("There is forward rx error in the network", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        count++;
                    }

                    if (PUErrReg.IsErrorRegisterIncreasing())
                    {
                        MessageBox.Show("There is process unit error in the network", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        count++;
                    }

                    if (LstLinkErrReg.IsErrorRegisterIncreasing())
                    {
                        MessageBox.Show("There is link lost error in the network", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        count++;
                    }
                    if (count== 0)
                    {
                        EndInput = true;
                    }

                }
                else 
                {
                    
                    break;
                }

            }


        }



        private static void ReadRegister(int slaveID, Register stRegister)
        {
            //-----------------------------------------------------------------
            // Read registers of the specified slave port.
            //-----------------------------------------------------------------
            EcLib.RegisterRead(slaveID,
                          stRegister.port[0],
                          stRegister.currentRegister);
        }


        public void HotConnectLogic()
        {
            for (int i = 0; i < 200000; i++)
            {
                // Check if all slaves are alive.
                nowAlive = IsAllAlive(ref isLost);
                if (nowAlive)
                {
                    MessageBox.Show("All Slaves are alive","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    EndInput = true;
                }
                else
                {
                    MessageBox.Show("One of the slave is not alive.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Resume communication when reconnection succeeds.
                if (isLost)
                {
                    EcLib.StartHotconnect();
                }

                // Check slave revived.
                if (nowAlive && !prevAlive)
                {
                    MessageBox.Show("Slave Revived", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //-------------------------------------------------------
                // Since an amp alarm may occur on the Slave side, 
                // Please clear the amp alarm.
                //-------------------------------------------------------

                prevAlive = nowAlive;
                System.Threading.Thread.Sleep(1000);

                // Check if "Q" key is pressed.
                if (EndInput)
                {
                    
                    break;
                }
            }

        }

        private static bool IsAllAlive(ref bool isLost)
        {
            bool bRet = true;

            EcLib.GetMasterInfo(MotorInfo);

            // Check Slave alive.
            isLost = false;
            for (int i = 0; i < MotorInfo.NumOfSlaves; i++)
            {
                if (MotorInfo.Slaves[i].State != EcStateMachine.Op)
                {
                    bRet = false;

                    // Check Slave lost. 
                    if ((MotorInfo.Slaves[i].State == EcStateMachine.None) ||
                         (MotorInfo.Slaves[i].State == EcStateMachine.Init))
                    {
                        isLost = true;
                    }
                }
            }

            return bRet;
        }

        private static bool IsReverse()
        {
            for (int i = 0; i < MotorInfo.NumOfSlaves; i++)
            {
                if (MotorInfo.Slaves[i].ReverseSlave)
                {
                    return true;
                }
            }

            return false;
        }

        public void CheckReverseConnection()
        {
            if (IsReverse())
            {
                MessageBox.Show("Warning! The Reverse Connection has been detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Normal Connection", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        public void WriteSDO(int slaveid,int indexvalue,int subindex,Int16 writesdodata)
        {
            // Start download SDO.
            sdoWriteBuff = BitConverter.GetBytes(writesdodata);
            EcLib.SdoDownload(slaveId, indexvalue, subindex, sdoWriteBuff, ref errorCode);

        }

        public int ReadSDO()
        {
            // It loads and displays the written SDO data.
            EcLib.SdoUpload(slaveId, index, subIndex, sdoReadBuff, ref actualSize, ref errorCode, waitTime);
            readSDOData = BitConverter.ToInt16(sdoReadBuff, 0);
            return readSDOData;
        }

        

    }
    class Register
    {
        public int registerSize;
        public ushort[] port;
        public byte[] currentRegister;
        public byte[] lstRegister;

        /*-------------------------------------------------------------------*/
        /* Function    : Register                                            */
        /* Description : Constructor of Register class.                      */
        /*-------------------------------------------------------------------*/
        public Register(int registerSize,
                        ushort port0 = 0x0000,
                        ushort port1 = 0x0000,
                        ushort port2 = 0x0000,
                        ushort port3 = 0x0000,
                        ushort port4 = 0x0000,
                        ushort port5 = 0x0000,
                        ushort port6 = 0x0000,
                        ushort port7 = 0x0000)
        {
            this.port = new ushort[8];
            this.port[0] = port0; this.port[1] = port1;
            this.port[2] = port2; this.port[3] = port3;
            this.port[4] = port4; this.port[5] = port5;
            this.port[6] = port6; this.port[7] = port7;
            this.registerSize = registerSize;
            this.currentRegister = Enumerable.Repeat<Byte>(0, registerSize).ToArray();
            this.lstRegister = Enumerable.Repeat<Byte>(0, registerSize).ToArray();
        }

        /*-------------------------------------------------------------------*/
        /* Function    : Register                                            */
        /* Description : Destructor of Register class.                       */
        /*               (started when Register class is destroyed.)         */
        /*-------------------------------------------------------------------*/
        ~Register()
        {
            this.port = null;
            this.currentRegister = null;
            this.lstRegister = null;
        }

        /*-------------------------------------------------------------------*/
        /* Function    : SaveCurrentRegister                                 */
        /* Description : Saves the current Register.                         */
        /*-------------------------------------------------------------------*/
        public void SaveCurrentRegister()
        {
            Array.Copy(this.lstRegister,
                       this.currentRegister,
                       this.registerSize * sizeof(byte));
        }

        /*-------------------------------------------------------------------*/
        /* Function    : Register::IsErrorRegisterIncreasing                 */
        /* Description : Compare with the previous Register, check if        */
        /*               there is an error Register.                         */
        /*-------------------------------------------------------------------*/
        public bool IsErrorRegisterIncreasing()
        {
            bool ret = false;
            for (int i = 0; i < this.registerSize; i++)
            {
                Console.Write(this.currentRegister[i].ToString("X2") + " ");

                // ------------------------------------------------------------
                // The user can check the error based on the Register data read 
                // in EcAPI -> ReadReg Method and judge whether to interrupt the
                // communication.
                // ------------------------------------------------------------
                if (this.currentRegister[i] != this.lstRegister[i])
                {
                    ret = true;
                }
            }

            Console.WriteLine("");

            return ret;
        }
    }
}
