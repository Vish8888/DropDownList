using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropDownListDemo.Models;


public class StudentVM
{
    public Student student { get; set; }

    public IEnumerable<SelectListItem> cityList { get; set; }
}