using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    public class QuestionDto // masz klase AnswerDto którą używasz, zrób tak aby QuestionDTO miało liste AnswerDTO i twoją główną klasą będzie QuestionDTO, CorrectAnswer wywal stąd bo możesz mieć wiele poprawnych odpowiedzi.
    {
        public string Question { get; set; }
        public string Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
