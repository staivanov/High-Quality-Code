using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grades cant be below zero!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Min grades cant be below zero!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("Max grades cant be below or equal to zero!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("Comments cant be null or zero!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
