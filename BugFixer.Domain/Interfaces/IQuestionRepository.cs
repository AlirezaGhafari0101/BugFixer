﻿using BugFixer.Domain.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixer.Domain.Interfaces
{
    public interface IQuestionRepository
    {
        Task SavechangeAsync();


        #region Question Methods
        Task<IEnumerable<Question>> GetQuestionsAsync();
        Task<Question> GetQuestionAsync(int id);
        Task CreateQuestionAsync(Question quesion);

        Task CreateQuestionTagAsync(QuestionTag questionTag);
        void UpdateQuestion(Question question);
        Task<int> GetUserQuestionsCountAsync(int userId);
        #endregion



        #region Answer Methods
        Task CreateAnswerAsync(Answer answer);
        IQueryable<Answer> QuestionAnswersQueryable(int id);
        void UpdateAnswer(Answer answer);
        Task<Answer> GetAnswerById(int id);
        Task<int> GetUserAnswersCountAsync(int userId);

        #endregion

        #region Profile
        Task<IEnumerable<Question>> ProfileSelectedQuestionsAsync(int id);

        Task<IEnumerable<Answer>> ProfileSelectedAswersAsync(int id);

        #endregion

    }
}
