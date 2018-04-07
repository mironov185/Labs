package sample;

import java.util.List;

public interface Air
{


        public static final String SQL_INSERT = "insert into aircraft (BoardRoom ,LimitPassenger,Type_,Make) values (?, ?, ?, ?)";
        public static final String SQL_UPDATE = "update  aircraft set  BoardRoom=? where AircrID  = ?";
        public static final String SQL_DELETE = "delete from  aircraft  where AircrID = ? ";

        public static final String SQL_INSERT1 = "insert into tickets (AircrID,FlightID,Price) values (?, ?, ?)";
        public static final String SQL_UPDATE1 = "update  tickets set  Price=? where TicketID  = ?";
        public static final String SQL_DELETE1 = "delete from  tickets  where TicketID = ? ";

        public static final String SQL_INSERT2 = "insert into flights (BoardRoom ,LimitPassenger,Type_,Make) values (?, ?, ?)";
        public static final String SQL_UPDATE2 = "update  flights set  Distation=? where FlightID  = ?";
        public static final String SQL_DELETE2 = "delete from  flights  where FlightID = ? ";


        public void insert(Air air);
        public void update(Air air);
        public void delete(Air air);




    }
