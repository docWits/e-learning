using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_learning
{
    public partial class fTest : Form
    {

        // Выходной лист вопросов    
        List<Questions> ListQuestions = new List<Questions>();

        // Выходной лист ответов
        List<Answers> ListAnswers = new List<Answers>();

        // Файл со списком вопросов
        String tempPath = @"C:\tmp\";

        // Счетчик вопросов
        int CountQuestions = 1;

        // Правильный ответ
        int TrueAnswer = 1;

        int MaxQuestionNumber = 0;
        public fTest()
        {
            InitializeComponent();

            // Получили данные при запуске программы
            ListDataQuestions();

            // Получили данные при запуске программы
            ListDataAnswers();

            MaxQuestionNumber = ListQuestions.Max(m => m.QuestionNumber);

            groupBox1.Visible = false;

            button1.Visible = false;

            button2.Visible = false;

            label2.Visible = false;
        }

       

        private void fTest_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        List<Answers> ListDataAnswers()
        {

            String path = tempPath + "answer.txt";
            File.WriteAllText(path, Properties.Resources.answer);
            string[] FromFile = File.ReadAllLines(path, Encoding.UTF8);

            Answers AnswersInfo = new Answers();

            for (int x = 0; x < FromFile.Length; x++)
            {
                var Data = FromFile[x].Split(';');
                Console.WriteLine(Data);
                AnswersInfo.QuestionNumber = Convert.ToInt32(Data[0]);

                AnswersInfo.AnswerText = Data[1];

                AnswersInfo.AnswerCorrect = Convert.ToInt32(Data[2]);

                ListAnswers.Add(AnswersInfo);
            }
            return ListAnswers;
        }


        // Получаем список вопросов
        List<Questions> ListDataQuestions()
        {

            String path = tempPath + "questions.txt";
            File.WriteAllText(path, Properties.Resources.questions);
            string[] FromFile = File.ReadAllLines(path, Encoding.UTF8);
            //string[] FromFile = Properties.Resources.questions;

            Questions QuestionsInfo = new Questions();

            for (int x = 0; x < FromFile.Length; x++)
            {
                var Data = FromFile[x].Split(';');

                QuestionsInfo.QuestionNumber = Convert.ToInt32(Data[0]);

                QuestionsInfo.QuestionText = Data[1];

                ListQuestions.Add(QuestionsInfo);
            }
            return ListQuestions;
        }

        void GetDataQuestionsAndAnswers()
        {
            var SelectQuestion = ListQuestions.Where(w => w.QuestionNumber == CountQuestions).Select(s => new { s.QuestionText, s.QuestionNumber });

            foreach (var Question in SelectQuestion)
            {
                label1.Text = Question.QuestionNumber + ".  " + Question.QuestionText;
            }

            var SelectAnswers = ListAnswers.Where(w => w.QuestionNumber == CountQuestions).Select(s => s.AnswerText);

            radioButton1.Text = SelectAnswers.ElementAt(0);

            radioButton2.Text = SelectAnswers.ElementAt(1);

            radioButton3.Text = SelectAnswers.ElementAt(2);
            radioButton4.Text = SelectAnswers.ElementAt(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            button1.Visible = true;

            button2.Visible = true;

            label2.Visible = true;

            button3.Enabled = false;

            button2.Enabled = false;

            GetDataQuestionsAndAnswers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MaxQuestionNumber < CountQuestions)
            {
                MessageBox.Show("Вы завершили тест");
            }
            else
            {
                GetDataQuestionsAndAnswers();

                radioButton1.ForeColor = Color.Black;

                radioButton2.ForeColor = Color.Black;

                radioButton3.ForeColor = Color.Black;
                radioButton4.ForeColor = Color.Black;

                button1.Enabled = true;

                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;

            radioButton2.ForeColor = Color.Black;

            radioButton3.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Black;

            for (int i = 0; i < 3; i++)
            {
                if (((RadioButton)groupBox1.Controls[i]).Checked)
                {
                    if (ListAnswers.Where(x => x.AnswerCorrect == 1).Any(w => w.AnswerText.Equals(groupBox1.Controls[i].Text.ToString())))
                    {
                        groupBox1.Controls[i].ForeColor = Color.Green;

                        MessageBox.Show("Правильный ответ");
                    }
                    else
                    {
                        groupBox1.Controls[i].ForeColor = Color.Red;

                        var TrueAnswer = ListAnswers.Where(x => x.AnswerCorrect == 1 && x.QuestionNumber == CountQuestions).Select(s => s.AnswerText);

                        foreach (string Row in TrueAnswer)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (groupBox1.Controls[j].Text.ToString() == Row)
                                {
                                    groupBox1.Controls[j].ForeColor = Color.Green;
                                }
                            }
                        }
                        MessageBox.Show($"Не правильный ответ");
                    }
                }
            }
            CountQuestions++;

            button1.Enabled = false;

            button2.Enabled = true;
        }
    
}

    public struct Answers
    {
        public int QuestionNumber { get; set; }

        public string AnswerText { get; set; }

        public int AnswerCorrect { get; set; }
    }

    // СТруктура вопросов
    public struct Questions
    {
        public int QuestionNumber { get; set; }

        public string QuestionText { get; set; }
    }
}
