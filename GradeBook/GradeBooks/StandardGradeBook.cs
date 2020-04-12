using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
