using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
 {
         new Sach {Id = 1,Title ="300 bài code thiếu nhi",AuthorName = "Phạm Gia Đức",Price = 1,Content = "Khơi gợi niềm cảm hứng lập trình với thiếu nhi" },
         new Sach {Id = 2,Title ="1001 bài code cho học sinh tiểu học",AuthorName = "Nguyễn Tấn Lợi",Price = 2,Content = "Giúp học sinh tiểu học làm quen với thuật toán" },
         new Sach { Id = 3, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName ="Nguyễn Nhật Ánh", Price = 1, Content="Truyện kể về Tuổi thơ..." },
         new Sach { Id = 4, Title = "Pro ASP.NET MVC5", AuthorName = "Adam", Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft’sASP.NET web platform.", Price = 3.75M }, };


        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}

