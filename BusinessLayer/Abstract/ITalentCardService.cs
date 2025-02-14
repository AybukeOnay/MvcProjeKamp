﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITalentCardService 
    {
        List<TalentCard> GetAll();
        TalentCard GetById(int id);
        void Add(TalentCard talentCard);
        void Update(TalentCard talentCard);
        void Delete(TalentCard talentCard);
    }
}
