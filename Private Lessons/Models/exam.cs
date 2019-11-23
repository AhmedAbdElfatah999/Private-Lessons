using System;
using System.ComponentModel.DataAnnotations;
namespace Private_Lessons.Models
{
    public partial class exam{

public int id { get; set; }
public string name { get; set; }
public int subject_id { get; set; }
public double max_marks { get; set; }
[DataType(DataType.Date)]
  public System.DateTime time { get; set; }




    }}