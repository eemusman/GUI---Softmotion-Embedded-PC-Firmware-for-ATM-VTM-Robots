using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMX3ApiCLR;
using System.Windows.Forms;
namespace GUIsf
{

    class Softmotion
    {

        enum TrajectoryProfile
        {
            Trapezoidal = 1, Scurve, JerkRatio, Parabolic, Sin, AdvancedS, TrapezoidalMAT, JerkLimited, JerkLimitedScurve, TwovelocityTrapezoid, TwovelocityScurve, TwovelcoityJerkratio, TimeaccTrapezoidal, TimeaccScurve, TimeaccJerkRatio, TimeaccParabolic, TimeaccS, TimeaccAdvancedS, ConstantDec, FixedvelJRatioT, FixedvelJRatioS, FixedvelJLimitedT, FixedvelJLimitedS
        }
        enum OVERRIDETYPE
        {
            PosOveride = 1, VelOveride, AccOverride, DecOverride, JerkAccOveride, JerkDecOverride, ProfileOverride
        }
        

        //Variable
        public static WMX3Api Wmxlib = new WMX3Api();
        public static CoreMotion Wmxlib_cm = new CoreMotion(Wmxlib);
        public static CoreMotionStatus CmStatus = new CoreMotionStatus();
        public static CoreMotionStatus CmStatus1 = new CoreMotionStatus();

        public static int[] err =new int[10];
        public static int errorindex = 0; 
        public static int firsterr = 0;
        public static int seconderr = 0;
        public HomeError herror;
        public const int MAXUSMANMOTOR = 50;
        static int NumOfMotor;
        public int AxisNo;
        public string AxisName = null;
        public float ActualPos;
        public float ComPos;
        public float ComVel;
        public float ComAcc;
        public float ComDcc;
        public bool LogicSVON;
        public bool busy;
        public bool init;
        public bool LogicNOT;
        public bool LogicPOT;
        public string ORG;
        public string Unit = null;
        public float speed;
        public float HomeAprSpeed;
        public float HomeClpSpeed;
        public float HomeAccel;
        public int PulseOutMode;
        public int PulseInMode;
        public bool EnablePOTNOT;
        public bool LogicALARM;
        public bool EnableALARM;
        public float UnitPerPulse;
        public float EncoderRatio;
        public float MaxPPS;
        public float MaxSpeed;
        public float MaxAccel;
        public bool MinMaxCheck;
        public float InPosRange;
        public float MinPosition;
        public float MaxPosition;
        public bool EnableSVRDY;
        public bool HomeLogic;
        public float HomeOffset;
        public int Category;
        public int HomeMode;
        public int BreakAddr;
        public string opstate;
        public float factor = 0.1f;
        public static double commandpos = 0;
        public static AxisSelection axissel=new AxisSelection();
        public static ErrorCode errortype = new ErrorCode();
        

        public struct MotionCheck { public float Pos1; public float Pos2; public int Delay; public float Speed; public float Accel;
            public MotionCheck(float pos1, float pos2, int delay, float speed, float accel)
            {
                Pos1 = pos1;
                Pos2 = pos2;
                Delay = delay;
                Speed = speed;
                Accel = accel;
            }
        }
        MotionCheck motioncheck;
        bool Dir;
        public double Target;
        static string FileName = "sample.txt";
        public static Softmotion[] softmotions = new Softmotion[MAXUSMANMOTOR];


        public Softmotion()
        {
            createdevice();
            startComm();
            axissel.AxisCount = MAXUSMANMOTOR;
            axissel.Axis =new int[MAXUSMANMOTOR];
            for (int i = 0; i < MAXUSMANMOTOR; i++)
            {
                axissel.Axis[i] = 0;
            }
        }


        public Softmotion(string filename)
        {
            FileName = filename;
            Alloc();
            OpenAll();

        }



        ~Softmotion()
        {
            //SaveAll();
            Free();
            stopComm();
            closedevice();
        }

        public static void AlarmClear()
        {
            Wmxlib_cm.AxisControl.ClearAmpAlarm(axissel);
            Wmxlib_cm.AxisControl.ClearAxisAlarm(axissel);
        }


        public static void HomeClear()
        {
            for (int i = 0; i < MAXUSMANMOTOR; i++)
            {
                byte value = 1;
                Wmxlib_cm.Home.SetHomeDone(i, value);
            }
            
        }

        public static string CheckError()
        {
            return WMX3Api.ErrorToString(err[errorindex]);

        }

        public static void Reset()
        {
            //What sort of reset

        }

        public static void AllStop()
        {
            Wmxlib_cm.Motion.Stop(axissel);
            
        }

        public static bool PosCheck(double pos,double range)
        {
            return Math.Abs(commandpos-pos)<=range;

        }

        public static void EStop()
        {
            Wmxlib_cm.ExecEStop(EStopLevel.Level1);
        }

        public int WaitMotion()
        {
            int i = -1;
            try
            {
                
                i=Wmxlib_cm.Motion.Wait(AxisNo);
            }
            catch (Exception)
            {

                MessageBox.Show("WaitMotion failed in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return i;
        }


        public static void execute()
        {

            getstatusupdate();
        }

        public static void getstatusupdate()
        {
            Wmxlib_cm.GetStatus(ref CmStatus);
            CoreMotionAxisStatus axisstat0 = CmStatus.AxesStatus[0];
            softmotions[0].LogicNOT = axisstat0.NegativeLS;
            softmotions[0].LogicPOT = axisstat0.PositiveLS;
            softmotions[0].LogicSVON = axisstat0.ServoOn;
            softmotions[0].ComPos = Convert.ToSingle(axisstat0.PosCmd);
            softmotions[0].ActualPos = Convert.ToSingle(axisstat0.ActualPos);
            softmotions[0].opstate = axisstat0.OpState.ToString();
            softmotions[0].LogicALARM = axisstat0.AmpAlarm;
            softmotions[0].HomeLogic = axisstat0.HomeDone;
            softmotions[0].herror = axisstat0.HomeError;
            Wmxlib_cm.GetStatus(ref CmStatus1);
            CoreMotionAxisStatus axisstat1 = CmStatus1.AxesStatus[1];
            softmotions[1].LogicNOT = axisstat1.NegativeLS;
            softmotions[1].LogicPOT = axisstat1.PositiveLS;
            softmotions[1].LogicSVON = axisstat1.ServoOn;
            softmotions[1].ComPos = Convert.ToSingle(axisstat1.PosCmd);
            softmotions[1].ActualPos = Convert.ToSingle(axisstat1.ActualPos);
            softmotions[1].opstate = axisstat1.OpState.ToString();
            softmotions[1].LogicALARM = axisstat1.AmpAlarm;
            softmotions[1].HomeLogic = axisstat1.HomeDone;
            softmotions[1].herror = axisstat1.HomeError;
            
        }
        
        public static void Free()
        {
            try
            {
                for (int i = 0; i < NumOfMotor; i++)
                {
                    if (softmotions[i] != null) { softmotions[i] = null; }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to Free in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            

        }

        public static void Alloc()
        {
            try
            {
                Free();
                OpenNumOf();
                for (int i = 0; i < NumOfMotor; i++)
                {
                    softmotions[i] = new Softmotion();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to Alloc in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            
        }


        public static void OpenNumOf()
        {

            try
            {
                IOFILE File;
                File = new IOFILE(FileName);
                int Num = File.ReadInteger("jjangMotor", "NumOfMotor");
                NumOfMotor = Num > 0 ? Num : 0;
                if(NumOfMotor > MAXUSMANMOTOR)
                {
                    NumOfMotor = 0;
                    MessageBox.Show("NumofMotor fail to OpenNumOf in Softmotion","File Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Opennumof fail in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        public static void OpenAll()
        {
            try
            {
                for (int i = 0; i < NumOfMotor; i++)
                {
                    softmotions[i].AxisNo = i;
                    softmotions[i].Open();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fail to Openall in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        public static void SaveAll()
        {
            try
            {
                for (int i = 0; i < NumOfMotor; i++)
                {
                    softmotions[i].Save();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fail to Saveall in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
        public void Open()
        {
            
            try
            {
                IOFILE File = new IOFILE(FileName);
                string Group = "[Axis" + AxisNo.ToString() + "]";


                AxisName = File.ReadString(Group, "Name");
                Unit = File.ReadString(Group, "Unit");
                speed = File.ReadFloat(Group, "speed");
                ActualPos = File.ReadFloat(Group, "Actual Pos");
                ComPos = File.ReadFloat(Group,"Comm. Pos");
                busy = File.ReadBool(Group,"Busy");
                init = File.ReadBool(Group,"Initialize");
                ORG = File.ReadString(Group, "ORG");
                Category = File.ReadInteger(Group, "Category");
                HomeMode = File.ReadInteger(Group, "HomeMode");
                HomeAprSpeed = File.ReadFloat(Group, "HomeAprSpeed");
                HomeClpSpeed = File.ReadFloat(Group, "HomeClpSpeed");
                HomeAccel = File.ReadFloat(Group, "HomeAccel");
                HomeLogic = File.ReadBool(Group, "HomeLogic");
                HomeOffset = File.ReadFloat(Group, "HomeOffset");
                InPosRange = File.ReadFloat(Group, "InPosRange");
                UnitPerPulse = File.ReadFloat(Group, "UnitPerPulse");
                EncoderRatio = File.ReadFloat(Group, "EncoderRatio");
                MaxPPS = File.ReadFloat(Group, "MaxPPS");
                MaxSpeed = File.ReadFloat(Group, "MaxSpeed");
                MaxAccel = File.ReadFloat(Group, "MaxAccel");

                MinMaxCheck = File.ReadBool(Group, "MinMaxCheck");
                MinPosition = File.ReadFloat(Group, "MinPosition");
                MaxPosition = File.ReadFloat(Group, "MaxPosition");

                PulseOutMode = File.ReadInteger(Group, "PulseOutMode");
                PulseInMode = File.ReadInteger(Group, "PulseInMode");

                LogicNOT = File.ReadBool(Group, "LogicNOT");
                LogicPOT = File.ReadBool(Group, "LogicPOT");
                EnablePOTNOT = File.ReadBool(Group, "EnablePOTNOT");
                LogicALARM = File.ReadBool(Group, "LogicALARM");
                EnableALARM = File.ReadBool(Group, "EnableALARM");
                EnableSVRDY = File.ReadBool(Group, "EnableSVRDY");
                LogicSVON = File.ReadBool(Group, "LogicSVON");
                BreakAddr = File.ReadInteger(Group, "BreakAddr");

                motioncheck.Pos1 = File.ReadFloat(Group, "Check_Pos1");
                motioncheck.Pos2 = File.ReadFloat(Group, "Check_Pos2");
                motioncheck.Delay = File.ReadInteger(Group, "Check_Delay");
                motioncheck.Speed = File.ReadFloat(Group, "Check_Speed");
                motioncheck.Accel = File.ReadFloat(Group, "Check_Accel");


                //initialize();
            }
            catch (Exception)
            {

                MessageBox.Show("Fail to Open in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        public void Save()
        {
            try
            {
                IOFILE File = new IOFILE(FileName);
                string Group = "Axis" + AxisNo.ToString();

                File.WriteString(Group, "Name", AxisName);
                File.WriteString(Group, "Unit",Unit);
                File.WriteFloat(Group, "speed",speed);
                File.WriteFloat(Group, "Actual Pos", ActualPos);
                File.WriteFloat(Group, "Comm. Pos", ComPos);
                File.WriteBool(Group, "Busy", busy);
                File.WriteBool(Group, "Initialize", init);
                File.WriteString(Group, "ORG", ORG);
                File.WriteInteger(Group, "Category", Category);
                File.WriteInteger(Group, "HomeMode", HomeMode);
                File.WriteFloat(Group, "HomeAprSpeed", HomeAprSpeed);
                File.WriteFloat(Group, "HomeClpSpeed", HomeClpSpeed);
                File.WriteFloat(Group, "HomeAccel", HomeAccel);
                File.WriteFloat(Group, "HomeOffset", HomeOffset);
                File.WriteBool(Group, "HomeLogic", HomeLogic);

                File.WriteFloat(Group, "InPosRange", InPosRange);

                File.WriteFloat(Group, "UnitPerPulse", UnitPerPulse);
                File.WriteFloat(Group, "EncoderRatio", EncoderRatio);

                File.WriteFloat(Group, "MaxPPS", MaxPPS);
                File.WriteFloat(Group, "MaxSpeed", MaxSpeed);
                File.WriteFloat(Group, "MaxAccel", MaxAccel);

                File.WriteBool(Group, "MinMaxCheck", MinMaxCheck);
                File.WriteFloat(Group, "MinPosition", MinPosition);
                File.WriteFloat(Group, "MaxPosition", MaxPosition);

                File.WriteInteger(Group, "PulseOutMode", PulseOutMode);
                File.WriteInteger(Group, "PulseInMode", PulseInMode);

                File.WriteBool(Group, "LogicNOT", LogicNOT);
                File.WriteBool(Group, "LogicPOT", LogicPOT);
                File.WriteBool(Group, "EnablePOTNOT", EnablePOTNOT);
                File.WriteBool(Group, "LogicALARM", LogicALARM);
                File.WriteBool(Group, "EnableALARM", EnableALARM);
                File.WriteBool(Group, "EnableSVRDY", EnableSVRDY);
                File.WriteBool(Group, "LogicSVON", LogicSVON);
                File.WriteInteger(Group, "BreakAddr", BreakAddr);

                File.WriteFloat(Group, "Check_Pos1", motioncheck.Pos1);
                File.WriteFloat(Group, "Check_Pos2", motioncheck.Pos2);
                File.WriteInteger(Group, "Check_Delay", motioncheck.Delay);
                File.WriteFloat(Group, "Check_Speed", motioncheck.Speed);
                File.WriteFloat(Group, "Check_Accel", motioncheck.Accel);
                //initialize();
            }
            catch (Exception)
            {

                MessageBox.Show("Fail to Save in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public void createdevice()
        {
            try
            {
                if (err[errorindex] != 0)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] =Wmxlib.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\", DeviceType.DeviceTypeNormal);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to CreateDevice in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        public void closedevice()
        {
            try
            {
                if (err[errorindex] != 0 ||errorindex!=99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] =Wmxlib.CloseDevice();
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to CloseDevice in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        // Start Communication
        public void startComm()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;
                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex]=Wmxlib.StartCommunication();
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to StartComm in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        //Stop Communication
        public void stopComm()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] =Wmxlib.StopCommunication();
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to StopComm in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public static bool AllservoON()
        {

            try
            {

                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.AxisControl.SetServoOn(axissel, 1);

                
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start AllServoON in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (err[errorindex] == 0) { return true; }
            else { return false; }
        }

        public static void AllservoOFF()
        {

            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.AxisControl.SetServoOn(axissel, 0);

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start ALLServoOFF in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //SERVO ON
        public void servoON()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.AxisControl.SetServoOn(AxisNo, 1);
               
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start ServoON in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        // SERVO OFF
        public void servoOFF()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.AxisControl.SetServoOn(AxisNo, 0);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start ServoOFF in Softmotion","Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public bool initialize()
        {
            try
            {
                FileName = "sample.txt";
                AxisNo = -1;
                Dir = false;
                Target = 0;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
            
        }

        public Config.SystemParam parameterload(Config.SystemParam param)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.Config.GetParam(ref param);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start parameterload in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return param;
        }

        public void paramatersave(Config.SystemParam param)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.Config.SetParam(param);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start paramatersave in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public CoreMotionAxisStatus GetStatus()
        {
            CoreMotionAxisStatus axisstat = new CoreMotionAxisStatus();
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.GetStatus(ref CmStatus);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start Getstatus in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            return axisstat;
        }
        public void setGearRatio( double encoderpulsesperrevolution, double encoderuserunitsperrevolution)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;
                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.Config.SetGearRatio(AxisNo, encoderpulsesperrevolution, encoderuserunitsperrevolution);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start setGearRatio in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public long getGearRatio( ref double Numerator, ref double Denominator)
        {
            long gearratio=0;
            try
            {
                gearratio=Wmxlib_cm.Config.GetGearRatio(AxisNo, ref Numerator, ref Denominator);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to start getGearRatio in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           return gearratio;
        }

        public void Stop()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                err[errorindex] = Wmxlib_cm.Motion.Stop(AxisNo);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Stop in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void JogMove(bool dir)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);

                Dir = dir;
                Motion.JogCommand jogCommand = new Motion.JogCommand();
                jogCommand.Profile.Type = ProfileType.SCurve;
                jogCommand.Axis = AxisNo;
                jogCommand.Profile.Acc = 1000000;
                jogCommand.Profile.Dec = 1000000;
                jogCommand.Profile.JerkAccRatio = 0.5;
                jogCommand.Profile.JerkDecRatio = 0.5;
                if (dir != true)
                    speed= -1 * speed;

                jogCommand.Profile.Velocity = speed;
                jogCommand.Profile.StartingVelocity = 0;
                jogCommand.Profile.JerkAcc = jogCommand.Profile.JerkDec = 1000;
                jogCommand.Profile.EndVelocity = jogCommand.Profile.StartingVelocity;

                err[errorindex] = Wmxlib_cm.Motion.StartJog(jogCommand);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to JogMove in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
        public void absolutemove(double target)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);

                Motion.PosCommand posCommand = new Motion.PosCommand();
                posCommand.Profile.Type = ProfileType.SCurve;
                posCommand.Axis = AxisNo;
                posCommand.Target = target;
                posCommand.Profile.Velocity = speed;
                posCommand.Profile.StartingVelocity = speed;
                posCommand.Profile.EndVelocity = speed;
                posCommand.Profile.Acc = factor * MaxAccel;
                posCommand.Profile.Dec = factor * MaxAccel;
                posCommand.Profile.JerkAcc = factor * MaxAccel;
                posCommand.Profile.JerkAccRatio = 0.5;
                posCommand.Profile.JerkDec = factor*MaxAccel;
                posCommand.Profile.JerkDecRatio = 0.5;

                err[errorindex] = Wmxlib_cm.Motion.StartPos(posCommand); //Absolute Move
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Absolutemove in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       

        public void relativemove(double target)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);

                factor = 0.1f;
                Motion.PosCommand posCommand = new Motion.PosCommand();
                posCommand.Profile.Type = ProfileType.SCurve;
                posCommand.Axis = AxisNo;
                posCommand.Target = target;
                posCommand.Profile.Velocity = speed;
                posCommand.Profile.StartingVelocity = speed;
                posCommand.Profile.EndVelocity = speed;
                posCommand.Profile.Acc = factor * MaxAccel;
                posCommand.Profile.Dec = factor * MaxAccel;
                posCommand.Profile.JerkAcc = factor * MaxAccel;
                posCommand.Profile.JerkAccRatio = 0.5;
                posCommand.Profile.JerkDec = factor * MaxAccel;
                posCommand.Profile.JerkDecRatio = 0.5;

                err[errorindex] = Wmxlib_cm.Motion.StartMov(posCommand);//relative move
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to relativemove in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void PosMove()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);

                Motion.PosCommand posCommand = new Motion.PosCommand();
                posCommand.Profile.Type = ProfileType.SCurve;
                posCommand.Axis = AxisNo;
                posCommand.Target = ComPos;
                posCommand.Profile.Velocity =ComVel;
                posCommand.Profile.StartingVelocity = 0;
                posCommand.Profile.EndVelocity = 0;
                posCommand.Profile.Acc = ComAcc;
                posCommand.Profile.Dec = ComDcc;
                posCommand.Profile.JerkAcc = 1000;
                posCommand.Profile.JerkAccRatio = 0.5;
                posCommand.Profile.JerkDec = 1000;
                posCommand.Profile.JerkDecRatio = 0.5;

                err[errorindex] = Wmxlib_cm.Motion.StartMov(posCommand);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Posmove in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Home()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);
                bool homedone = false;
                Config.HomeParam homeParam = new Config.HomeParam();
                homeParam.HomeType = Config.HomeType.CurrentPos;
                err[errorindex] = Wmxlib_cm.Config.SetHomeParam(AxisNo, homeParam);
                err[errorindex] = Wmxlib_cm.Home.StartHome(AxisNo);
                err[errorindex] = Wmxlib_cm.Motion.Wait(AxisNo);
                while (homedone)
                {
                    err[errorindex] = Wmxlib_cm.GetStatus(ref CmStatus);
                    homedone = CmStatus.AxesStatus[AxisNo].HomeDone;
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Home in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void BlockAxisMotion()
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err,0,err.Length);
                err[errorindex] = Wmxlib_cm.Motion.Wait(AxisNo);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to BlockAxisMotion in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void OverrideAxisModxtion(bool relorabs, int overridetype, Motion.PosCommand pos)
        {
            try
            {
                if (err[errorindex] != 0 || errorindex != 99)
                {
                    errorindex++;

                }
                else Array.Clear(err, 0, err.Length);

                switch (overridetype)
                {
                    case (int)OVERRIDETYPE.PosOveride:
                        if (relorabs == true)
                            err[errorindex] = Wmxlib_cm.Motion.OverridePos(pos);
                        else
                            err[errorindex] = Wmxlib_cm.Motion.OverrideMov(pos);
                        break;
                    case (int)OVERRIDETYPE.VelOveride:
                        err[errorindex] = Wmxlib_cm.Motion.OverrideVel(pos);
                        break;
                    case (int)OVERRIDETYPE.AccOverride:
                        err[errorindex] = Wmxlib_cm.Motion.OverrideAcc(pos);
                        break;
                    case (int)OVERRIDETYPE.DecOverride:
                        err[errorindex] = Wmxlib_cm.Motion.OverrideDec(pos);
                        break;
                    case (int)OVERRIDETYPE.JerkAccOveride:
                        err[errorindex] = Wmxlib_cm.Motion.OverrideJerkAcc(pos);
                        break;
                    case (int)OVERRIDETYPE.JerkDecOverride:
                        err[errorindex] = Wmxlib_cm.Motion.OverrideJerkDec(pos);
                        break;
                    case (int)OVERRIDETYPE.ProfileOverride:
                        err[errorindex] = Wmxlib_cm.Motion.OverrideProfile(pos);
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to OverrideAxisMotion in Softmotion", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

    }
}
