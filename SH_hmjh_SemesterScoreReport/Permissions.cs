using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SH_hmjh_SemesterScoreReport
{
    class Permissions
    {
        public static string KeyHmjhSemesterScoreReport { get { return "SHSchool.SH_hmjh_SemesterScoreReport.cs"; } }
        public static bool IsEnableHmjhSemesterScoreReport
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[KeyHmjhSemesterScoreReport].Executable;
            }
        }
    }
}
