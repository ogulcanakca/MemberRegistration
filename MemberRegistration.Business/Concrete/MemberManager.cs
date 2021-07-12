using ELibrary.Library.Core.Aspects.Postsharp.ValidationAspects;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _kpsService = kpsService;
            _memberDal = memberDal;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckIfMemberExists(member);
           CheckIfUserFromKps(member);
            

            _memberDal.Add(member);
        }

        private void CheckIfUserFromKps(Member member)
        {
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil.");
            }

        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("Bu kullanıcı daha önce kayıt olmuştur.");
            }
        }
    }
}
