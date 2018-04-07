package sample;

import java.util.Date;

public class Aircraft {

    public Aircraft(int airID,int boardRoom, int limitPassenger,String type, String make) {
        BoardRoom = boardRoom;
        LimitPassenger = limitPassenger;
        Type = type;
        Make = make;
        AirID = airID;
    }

    public void setBoardRoom(int boardRoom) {
        BoardRoom = boardRoom;
    }

    public void setLimitPassenger(int limitPassenger) {
        LimitPassenger = limitPassenger;
    }


    public void setType(String type) {
        Type = type;
    }

    public void setMake(String make) {
        Make = make;
    }

    public int getBoardRoom() {

        return BoardRoom;
    }

    public int getLimitPassenger() {
        return LimitPassenger;
    }


    public String getType() {
        return Type;
    }

    public String getMake() {
        return Make;
    }

    public int BoardRoom;
    public int LimitPassenger;
    public String Type;
    public String Make;

    public int getAirID() {
        return AirID;
    }

    public void setAirID(int airID) {
        AirID = airID;
    }

    public int AirID;


    public Aircraft()
    {
    }


}
