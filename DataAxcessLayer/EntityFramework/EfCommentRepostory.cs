using DataAxcessLayer.Abstract;
using DataAxcessLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAxcessLayer.EntityFramework
{
    public class EfCommentRepostory : GenericRepostory<Comment>, ICommentDal
    {
    }
}
