using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Private_Lessons.Models
{
    public partial class student_exams{
            [Key]
public int id { get; set; }
      public int student_id { get; set; }
      public int exam_id { get; set; }

    }}