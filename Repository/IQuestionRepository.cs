﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace Repository
{
    public interface IQuestionRepository
    {
        Task<List<InterviewQuestion>> getAllQuestion();

        Task<List<InterviewQuestion>> getQuestionByID(int id);

        Task addQuestion(InterviewQuestion question);

        Task<InterviewQuestion> updateQuestion(InterviewQuestion interviewQuestion);

    }
}