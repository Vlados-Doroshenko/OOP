using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace laba4
{
    class Files
    {
        private int sum;
        private int count;
        string path = $@"D:/file/";
        string NoFile = "";
        string OverflowFile = "";
        string BadFile = "";

        public void AvailabilityFile()
        {
            if (!File.Exists(path + "overflow.txt"))
            {
                File.CreateText(path + "overflow.txt");
            }
            if (!File.Exists(path + "bad_data.txt"))
            {
                File.CreateText(path + "bad_data.txt");
            }
            if (!File.Exists(path + "no_file.txt"))
            {
                File.CreateText(path + "no_file.txt");
            }
            try
            {
                for (int i = 10; i <= 29; i++)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader($"{path}{i}.txt"))
                        {
                            int firstNumber = int.Parse(reader.ReadLine());
                            int secondNumber = int.Parse(reader.ReadLine());
                            sum += firstNumber * secondNumber;
                            count++;
                        }
                    }
                    catch (OverflowException e)
                    {
                        if (File.Exists(path + "overflow.txt"))
                        {
                            try
                            {
                                using (StreamWriter writer = new StreamWriter(path + "overflow.txt", true))
                                {
                                    {

                                        OverflowFile += "\n" + (i + 10) + ".txt " + e;
                                        writer.Write(OverflowFile);


                                    }
                                    writer.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                
                            }
                        }
                    }
                    catch (FileNotFoundException e)
                    {
                        if (File.Exists(path + "no_file.txt"))
                        {
                            try
                            {
                                using (StreamWriter writer = new StreamWriter(path + "no_file.txt", true))
                                {
                                    {

                                        NoFile += "\n" + (i + 10) + ".txt " + e;
                                        writer.Write(NoFile);


                                    }
                                    writer.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.Error.WriteLine(ex.Message);
                            }
                        }
                    }
                    catch (FormatException e)
                    {
                        if (File.Exists(path + "bad_data.txt"))
                        {
                            try
                            {
                                using (StreamWriter writer = new StreamWriter(path + "bad_data.txt", true))
                                {
                                    {

                                        BadFile += "\n" + (i + 10) + ".txt " + e;
                                        writer.Write(BadFile);


                                    }
                                    writer.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.Error.WriteLine(ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }

        }
        private void AddText(int NumFile, string ResFile, string TextFile)
        {
            using (FileStream file = new FileStream(path + ResFile, FileMode.Append))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.WriteLine($"File {NumFile}.txt - {TextFile}");
                }
            }
        }

    }       
}
