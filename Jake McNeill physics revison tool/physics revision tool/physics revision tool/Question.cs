using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV2_71371_4615
{
    class Question
    {

        private string _QuestionText;
        private string _CorrectAnswer;
        private string _incorrectAnswer1;
        private string _incorrectAnswer2;
        private string _incorrectAnswer3;
        private string _incorrectAnswer4;
        private string _incorrectAnswer5;
        private string _textline1;
        private string _textline2;
        private string _textline3;
        private string _textline4;
        private string _textline5;


        public Question(string questionText, string correctAnswer, string incorrectAnswer1, string incorrectAnswer2, string incorrectAnswer3, string incorrectAnswer4, string incorrectAnswer5, string textline1, string textline2, string textline3, string textline4, string textline5)
        {
            _QuestionText = questionText;
            _CorrectAnswer = correctAnswer;
            _incorrectAnswer1 = incorrectAnswer1;
            _incorrectAnswer2 = incorrectAnswer2;
            _incorrectAnswer3 = incorrectAnswer3;
            _incorrectAnswer4 = incorrectAnswer4;
            _incorrectAnswer5 = incorrectAnswer5;
            _textline1 = textline1;
            _textline2 = textline2;
            _textline3 = textline3;
            _textline4 = textline4;
            _textline5 = textline5;
        }
        public Question()
        {
        }

        public string QuestionText { get => _QuestionText; set => _QuestionText = value; }
        public string CorrectAnswer { get => _CorrectAnswer; set => _CorrectAnswer = value; }
        public string IncorrectAnswer1 { get => _incorrectAnswer1; set => _incorrectAnswer1 = value; }
        public string IncorrectAnswer2 { get => _incorrectAnswer2; set => _incorrectAnswer2 = value; }
        public string IncorrectAnswer3 { get => _incorrectAnswer3; set => _incorrectAnswer3 = value; }
        public string IncorrectAnswer4 { get => _incorrectAnswer4; set => _incorrectAnswer4 = value; }
        public string IncorrectAnswer5 { get => _incorrectAnswer5; set => _incorrectAnswer5 = value; }
        public string Textline1 { get => _textline1; set => _textline1 = value; }
        public string Textline2 { get => _textline2; set => _textline2 = value; }
        public string Textline3 { get => _textline3; set => _textline3 = value; }
        public string Textline4 { get => _textline4; set => _textline4 = value; }
        public string Textline5 { get => _textline5; set => _textline5 = value; }
    }
       
    }

