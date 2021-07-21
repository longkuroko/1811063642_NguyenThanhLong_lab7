using BAITAPCUOICUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BAITAPCUOICUNG.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach
            {
                Id =1,
                Title =" Tôi thấy hoa vàng trên cỏ xanh",
                AuthorName = "Nguyễn Nhật Ánh",
                Price = 1,
                Content = "Truyện kể về tuổi thơ..."
            },
            new Sach
            {
                Id =2,
                Title =" Harry Potter",
                AuthorName = "J. K. Rowling",
                Price = 1,
                Content = "Truyện kể về thế giới phép thuật..."
            }

        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }

       
    }
}
