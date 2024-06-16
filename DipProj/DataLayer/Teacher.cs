namespace DipProj;
public class Teacher
{
    public int ID { get; set; }
    public string FullName { get; set; }
    public int WorkingLoad { get; set; }

    public Teacher(int ID, string FullName, int WorkingLoad){
        this.ID = ID;
        this.FullName = FullName;
        this.WorkingLoad = WorkingLoad;
    }
}