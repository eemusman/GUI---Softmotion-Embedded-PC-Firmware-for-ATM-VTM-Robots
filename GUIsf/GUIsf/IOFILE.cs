using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GUIsf
{
    class IOFILE
    {
        //Variables
        string FileName;
        string[] lines;
        string[] tags;
        string[] tagvalue;
        string value;
        int counter1;
        int counter2;

        // Constructor for IOFILE Class
        public IOFILE(string filename)
        {
            FileName = filename;
        }

        // Finds Label and Tag for Writing to the file
        private void FindLabelTagWrite(string Label, string Tag, string Value)
        {
            lines = File.ReadAllLines(FileName);
            tags = new string[lines.Length];
            counter1 = 0;
            counter2 = 0;
            foreach (var line in lines)
            {
                if (line.Contains(Label))
                {
                    Array.Copy(lines, counter1, tags, 0, lines.Length - counter1);
                    foreach (var tag in tags)
                    {
                        if (tag.Contains(Tag))
                        {
                            tagvalue = tag.Split('=');
                            tags[counter2].Replace(tagvalue[1], Value);
                            Array.Copy(tags, counter2, lines, counter1 + counter2, tag.Length);
                            break;
                        }
                        ++counter2;
                    }
                }

                ++counter1;

            }
            File.WriteAllLines(FileName,lines);

        }
        // Finds Label and Tag for Reading to the file
        private string FindLableTagRead(string Label, string Tag)
        {
            lines = File.ReadAllLines(FileName);
            tags = new string[lines.Length];
            value=null;
            counter1 = 0;
            counter2 = 0;
            foreach (var line in lines)
            {
                if (line.Contains(Label))
                {
                    Array.Copy(lines, counter1, tags, 0, lines.Length - counter1);
                    foreach (var tag in tags)
                    {
                        if (tag.Contains(Tag))
                        {
                            tagvalue = tag.Split('=');
                            value = tagvalue[1];
                            break;
                        }
                        ++counter2;
                    }
                }
                ++counter1;
            }

            return value;
        }

        //
        private string[] FindLabelRead(string Label)
        {
            lines = File.ReadAllLines(FileName);
            counter1 = 0;
            counter2 = 0;
            string[] clines;
            string[] values;
            foreach (var line in lines)
            {
                if (line.Contains(Label))
                {
                    clines = new string[lines.Length - counter1];
                    Array.Copy(lines, counter1, clines, 0, lines.Length - counter1);
                    foreach (var cline in clines)
                    {
                        if (cline=="")
                        {
                            values = new string[counter2];
                            Array.Copy(clines,0,values,0,counter2);
                            tags = values;
                            break;
                        }
                        ++counter2;
                    }
                }
                ++counter1;
            }
            return tags;
        }

        // Read all the lines below the label
        public string[] ReadParam(string Label)
        {
            return FindLabelRead(Label);
        }
        // Read the String value for the given label and tag
        public string ReadString(string Label, string Tag)
        {
            return FindLableTagRead(Label,Tag);
        }

        //Write the String value for the given label and tag
        public void WriteString(string Label, string Tag, string Value)
        {
            FindLabelTagWrite(Label, Tag, Value);
        }
        //Read the integer value for the given label and tag
        public int ReadInteger(string Label, string Tag)
        {
            int intvalue = int.Parse(FindLableTagRead(Label, Tag));
            return intvalue;
        }
        //Write the integer value for the given label and tag
        public void WriteInteger(string Label, string Tag, int Value)
        {
            FindLabelTagWrite(Label, Tag, Value.ToString());
        }
        //Read the float value for the given label and tag
        public float ReadFloat(string Label, string Tag)
        {
           float floatvalue= float.Parse(FindLableTagRead(Label, Tag));
            return floatvalue;
        }
        //Write the String value for the given label and tag
        public void WriteFloat(string Label, string Tag, float Value)
        {
            FindLabelTagWrite(Label,Tag,Value.ToString());
        }
        //Read the bool value for the given label and tag
        public bool ReadBool(string Label, string Tag)
        {
            bool boolvalue = bool.Parse(FindLableTagRead(Label, Tag));
            return boolvalue;
        }
        //Write the bool value for the given label and tag
        public void WriteBool(string Label, string Tag, bool Value)
        {
            FindLabelTagWrite(Label, Tag, Value.ToString());
        }
    }
}
