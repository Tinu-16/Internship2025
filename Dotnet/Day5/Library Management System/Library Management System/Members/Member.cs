using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Members
{
    public  class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public Member(int memberId, string memberName)
        {
            MemberId = memberId;
            MemberName = memberName;
        }
        public override string ToString()
        {
            return $"Member id is {MemberId} and Member name is {MemberName}";
        }
    }
}
