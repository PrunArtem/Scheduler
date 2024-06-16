namespace DipProj;
public class SpecializedRoom
{
    public int RoomNumber { get; set; }
    public int SubjectID { get; set; }
    public SpecializedRoom(int RoomNumber, int SubjectID){
        this.RoomNumber = RoomNumber;
        this.SubjectID = SubjectID;
    }
}