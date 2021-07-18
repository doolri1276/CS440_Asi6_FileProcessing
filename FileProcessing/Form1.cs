using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class Form1 : Form
    {
        ArrayList STList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadStudents_Click(object sender, EventArgs e)
        {
            try
            {
                //string filename = "c:\temp\students.txt";
                //string filename = @"c:\temp\students.txt";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\temp";
                ofd.Filter = "text files|*.txt|docx files|*.docx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;


                    FileInfo fi = new FileInfo(filename);

                    //we need to associate a stream object with
                    //the file object before we can read data from it
                    Stream str = fi.Open(FileMode.Open, FileAccess.Read);

                    //stream is binary stream
                    //Decorator pattern - a decorator pattern allows
                    //one class type to be converted to another
                    //via the constructor
                    StreamReader sstr = new StreamReader(str);

                    //Stream Reader is a text type of stream
                    string sLine = sstr.ReadLine();
                    //MessageBox.Show(sLine);
                    char[] seps = { ',' };
                    while (sLine != null)
                    {
                        string[] parts = sLine.Split(seps);
                        Student st = new Student();
                        st.FirstName = parts[0];
                        st.LastName = parts[1];
                        st.Id = int.Parse(parts[2]);
                        st.Test1 = int.Parse(parts[3]);
                        st.Test2 = int.Parse(parts[4]);
                        st.Grade = st.ComputeGrade();
                        st.Gpa = double.Parse(parts[5]);
                        STList.Add(st);
                        sLine = sstr.ReadLine();
                        if (sLine == null)
                            break;
                        if (sLine.Trim() == "")
                            break;
                    }

                    //Display the array list
                    //C# has a concept of data binding
                    //Databinding is a two step process
                    //Step 1 : assign the datasource to a UI element
                    //Step 2 : call refresh to display data
                    dgStudents.DataSource = STList;
                    dgStudents.Refresh();
                }
            }catch (FileNotFoundException fe)
            {
                MessageBox.Show("FE : "+fe.Message);
            }catch (Exception ex)
            {
                MessageBox.Show("EX : " + ex.Message+"\n"+
                    ex.StackTrace);

            }
            MessageBox.Show("After catches");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //to display Login form in a modal manner
            FormLogin fmLogin = new FormLogin();
            if(fmLogin.ShowDialog() == DialogResult.OK)
            {
                //collect username, password from the login dialog
                string username = fmLogin.Username;
                string password = fmLogin.Password;
                //check DB to see if valid user
                if ((username == "bill") && password == "bill100")
                    MessageBox.Show("Welcome " + username);
                else
                    MessageBox.Show("Invalid login..");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "menuSelectData")
            {
                try
                {
                    //string filename = "c:\temp\students.txt";
                    //string filename = @"c:\temp\students.txt";
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.InitialDirectory = "C:\\temp";
                    ofd.Filter = "text files|*.txt|docx files|*.docx";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = ofd.FileName;


                        FileInfo fi = new FileInfo(filename);

                        //we need to associate a stream object with
                        //the file object before we can read data from it
                        Stream str = fi.Open(FileMode.Open, FileAccess.Read);

                        //stream is binary stream
                        //Decorator pattern - a decorator pattern allows
                        //one class type to be converted to another
                        //via the constructor
                        StreamReader sstr = new StreamReader(str);

                        //Stream Reader is a text type of stream
                        string sLine = sstr.ReadLine();
                        //MessageBox.Show(sLine);
                        char[] seps = { ',' };
                        while (sLine != null)
                        {
                            string[] parts = sLine.Split(seps);
                            Student st = new Student();
                            st.Id = int.Parse(parts[0]);
                            st.FirstName = parts[1];
                            st.LastName = parts[2];
                            st.Test1 = int.Parse(parts[3]);
                            st.Test2 = int.Parse(parts[4]);
                            st.Major = parts[5];
                            st.Degree = parts[6];
                            STList.Add(st);
                            sLine = sstr.ReadLine();
                            if (sLine == null)
                                break;
                            if (sLine.Trim() == "")
                                break;
                        }

                        //Display the array list
                        //C# has a concept of data binding
                        //Databinding is a two step process
                        //Step 1 : assign the datasource to a UI element
                        //Step 2 : call refresh to display data
                        dgStudents.DataSource = STList;
                        dgStudents.Refresh();
                    }
                }
                catch (FileNotFoundException fe)
                {
                    MessageBox.Show("FE : " + fe.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EX : " + ex.Message + "\n" +
                        ex.StackTrace);

                }
                MessageBox.Show("After catches");
            }
            else if (e.ClickedItem.Name == "menuSaveData")
            {
                try
                {
                    //string filename = "c:\temp\students.txt";
                    //string filename = @"c:\temp\students.txt";
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.InitialDirectory = "C:\\temp";
                    sfd.Filter = "text files|*.txt|docx files|*.docx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = sfd.FileName;


                        FileInfo fi = new FileInfo(filename);

                        //we need to associate a stream object with
                        //the file object before we can read data from it
                        Stream str = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);

                        //stream is binary stream
                        //Decorator pattern - a decorator pattern allows
                        //one class type to be converted to another
                        //via the constructor
                        StreamWriter sstr = new StreamWriter(str);

                        foreach (Student st in STList)
                        {

                            sstr.WriteLine(st.Id + "," + st.LastName + "," + st.Major + "," + st.ComputeGrade());
                        }
                        sstr.Flush();
                        sstr.Close();
                    }
                }
                catch (FileNotFoundException fe)
                {
                    MessageBox.Show("FE : " + fe.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EX : " + ex.Message + "\n" +
                        ex.StackTrace);

                }
                MessageBox.Show("After catches");
            }
            else if (e.ClickedItem.Name == "menuAddStudent")
            {
                FormAddStudent fmAddStudent = new FormAddStudent();
                if (fmAddStudent.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //collect username, password from the login dialog

                        int id = fmAddStudent.ID;
                        string firstName = fmAddStudent.FirstName;
                        string lastName = fmAddStudent.LastName;
                        int test1 = fmAddStudent.Test1;
                        int test2 = fmAddStudent.Test2;
                        string major = fmAddStudent.Major;
                        string degree = fmAddStudent.Degree;
                        if (id.ToString().Length == 0)
                        {
                            throw new Exception("invalid ID");
                        }
                        foreach (Student s in STList)
                        {
                            if (s.Id == id) throw new Exception("duplicated ID");
                        }
                        if (firstName.Length == 0) throw new Exception("invalid FirstName");
                        if (lastName.Length == 0) throw new Exception("invalid LastName");
                        if (test1 < 0 || test1 > 100) throw new Exception("invalid Test1");
                        if (test2 < 0 || test2 > 100) throw new Exception("invalid Test2");
                        if (major.Length == 0) throw new Exception("invalid Major");
                        Student st = new Student();
                        st.Id = id;
                        st.FirstName = firstName;
                        st.LastName = lastName;
                        st.Test1 = test1;
                        st.Test2 = test2;
                        st.Major = major;
                        st.Degree = degree;
                        STList.Add(st);
                        dgStudents.DataSource = STList;
                        dgStudents.Update();
                        dgStudents.Refresh();
                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    //string filename = "c:\temp\students.txt";
                    //string filename = @"c:\temp\students.txt";
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.InitialDirectory = "C:\\temp";
                    ofd.Filter = "text files|*.txt|docx files|*.docx";
                    STList = new ArrayList();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = ofd.FileName;


                        FileInfo fi = new FileInfo(filename);

                        //we need to associate a stream object with
                        //the file object before we can read data from it
                        Stream str = fi.Open(FileMode.Open, FileAccess.Read);

                        //stream is binary stream
                        //Decorator pattern - a decorator pattern allows
                        //one class type to be converted to another
                        //via the constructor
                        StreamReader sstr = new StreamReader(str);

                        //Stream Reader is a text type of stream
                        string sLine = sstr.ReadLine();
                        //MessageBox.Show(sLine);
                        char[] seps = { ',' };
                        while (sLine != null)
                        {
                            string[] parts = sLine.Split(seps);
                            Student st = new Student();
                            st.Id = int.Parse(parts[0]);
                            st.LastName = parts[1];
                            st.Major = parts[2];
                            st.Grade = parts[3];
                            STList.Add(st);
                            sLine = sstr.ReadLine();
                            if (sLine == null)
                                break;
                            if (sLine.Trim() == "")
                                break;
                        }

                        //Display the array list
                        //C# has a concept of data binding
                        //Databinding is a two step process
                        //Step 1 : assign the datasource to a UI element
                        //Step 2 : call refresh to display data
                        dgStudents.DataSource = STList;
                        dgStudents.Refresh();
                    }
                }
                catch (FileNotFoundException fe)
                {
                    MessageBox.Show("FE : " + fe.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EX : " + ex.Message + "\n" +
                        ex.StackTrace);

                }
                MessageBox.Show("After catches");
            }
                    
        }
    }
}
