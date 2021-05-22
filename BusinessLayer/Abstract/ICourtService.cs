using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICourtService
    {
        Court Get(int id);
        IList<Court> GetList();
        IList<Court> Search(string CourtNo);
        string GetJudgeWithCourtNo(int CourtNo);
        int GetIdWithCourtNo(int CourtNo);
        void Add(Court obj);
        void Update(Court obj);
        void Delete(Court obj);
    }
}
