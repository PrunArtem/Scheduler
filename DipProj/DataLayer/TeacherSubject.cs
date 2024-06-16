namespace DipProj;
public class TeacherSubject
{
    public int TeacherID { get; set; }
    public int SubjectID { get; set; }
    public int HoursPerWeek { get; set; }
    public TeacherSubject(int TeacherID, int SubjectID, int HoursPerWeek){
        this.TeacherID = TeacherID;
        this.SubjectID = SubjectID;
        this.HoursPerWeek = HoursPerWeek;
    }
}