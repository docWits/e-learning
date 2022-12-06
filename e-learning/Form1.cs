using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace e_learning
{
    public partial class Form1 : Form
    {
        Lecture lecture = new Lecture();
        fTest fTest = new fTest();
        String tempPath = @"C:\tmp\";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private String loadLec(String textPath)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(textPath + ".txt");
                line = sr.ReadToEnd();
                sr.Close();
                return line;
            }
            catch (Exception E)
            {
                return E.Message;
            }
        }
        private void текстоваяВерсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = " ";
            lecture.lectureText.Text = Properties.Resources.lec1;
            lecture.ShowDialog();
        }

        private void тестоваяВерсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lec2;
            lecture.ShowDialog();
        }

        private void текстоваяВерсияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = " ";
            lecture.lectureText.Text = Properties.Resources.lec3;
            lecture.ShowDialog();
        }

        private void текстоваяВерсияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = " ";
            lecture.lectureText.Text = Properties.Resources.lec4;
            lecture.ShowDialog();
        }

        private void текстоваяВерсияToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lec9;
            lecture.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lec6;
            lecture.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lec7;
            lecture.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lec8;
            lecture.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = " ";
            lecture.lectureText.Text = Properties.Resources.lec5;
            lecture.ShowDialog();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = " ";
            lecture.lectureText.Text = Properties.Resources.lec10;
            lecture.ShowDialog();
        }

        private void текстоваяВерсияToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lec11;
            lecture.ShowDialog();
        }


        private void тема1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.control1;
            lecture.ShowDialog();
        }

        private void тема2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.control2;
            lecture.ShowDialog();
        }

        private void тема3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.control3;
            lecture.ShowDialog();
        }

        private void тема4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.control4;
            lecture.ShowDialog();
        }

        private void тема5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.control5;
            lecture.ShowDialog();
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.practice1;
            lecture.ShowDialog();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.practice2;
            lecture.ShowDialog();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.practice3;
            lecture.ShowDialog();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.practice4;
            lecture.ShowDialog();
        }

        private void презентацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp1.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp1);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void презентацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp2.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp2);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void презентацияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp3.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp3);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void презентацияToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp4.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp4);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp5.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp5);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp6.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp6);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp8.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp8);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void презентацияToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp8.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp8);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            String path = tempPath + "pp8.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp8);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void презентацияToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            String path = tempPath + "p11.pptx";
            File.WriteAllBytes(path, Properties.Resources.pp11);
            PowerPoint.Application application = new PowerPoint.Application();
            application.Presentations.Open2007(path);
        }

        private void краткоеСодержаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.summary;
            lecture.ShowDialog();
        }

        private void переченьНеобходимыхИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.scr;
            lecture.ShowDialog();
        }

        private void литератураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.lib;
            lecture.ShowDialog();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture.lectureText.Text = "";
            lecture.lectureText.Text = Properties.Resources.author;
            lecture.ShowDialog();
        }

        private void итоговыйТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTest.ShowDialog();
        }
    }
}
