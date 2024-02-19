using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmenDataAccessLayer.Repositories;
using FoodyTekmerEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmenDataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial> , ITestimonialDal
    {

    }
}
