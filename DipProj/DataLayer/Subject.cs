namespace DipProj;
public class Subject
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool NeedInSpecializedRoom { get; set; }
    //public string OptimizationCriteria { get; set; }
    public Subject(int ID, string Name, bool NeedInSpecializedRoom/*, string OptimizationCriteria*/){
        this.ID = ID;
        this.Name = Name;
        this.NeedInSpecializedRoom = NeedInSpecializedRoom;
    }
}