﻿namespace Domain.Models;

public class Exam
{
    public int Id { get; set; }
    public int ExamTypeId { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}