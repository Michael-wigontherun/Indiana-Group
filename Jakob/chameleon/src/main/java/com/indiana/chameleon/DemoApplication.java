package com.indiana.chameleon;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import java.util.*;
import org.springframework.web.bind.annotation.*;
import java.sql.*;

@RestController
@SpringBootApplication
public class DemoApplication {

	public static void main(String[] args) {
		SpringApplication.run(DemoApplication.class, args);
	}

	@RequestMapping(value = "/", method = RequestMethod.GET)
	public List<LiquidTable> compareTable() {
		List response = new ArrayList<LiquidTable>();
		List response2 = new ArrayList<TruckingTable>();
		Connect database = new Connect();
		String SQL;
		SQL = "select * from LiquidatedCompanys";
		LiquidTable table = new LiquidTable();
		TruckingTable truck = new TruckingTable();
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn = DriverManager.getConnection(database.connection);
            Statement stmt = conn.createStatement();
			ResultSet records = stmt.executeQuery(SQL);
			while(records.next()){
				table = new LiquidTable();
				table.USDOT = records.getString("USDOT");
				table.LegalName = records.getString("LegalName");
				table.DBAName = records.getString("DBAName");
				table.Address = records.getString("Address");
				table.OOSReason = records.getString("OOSReason");
				table.OOSDate = records.getString("OOSDate");
				table.Status = records.getString("Status");
				table.GeoLocation = records.getString("GeoLocation");
				table.adminID = records.getString("addminID");
				response.add(table);
			}
			SQL = "select * from TruckingCompanies";
			ResultSet records2 = stmt.executeQuery(SQL);

			while(records.next()){
				truck = new TruckingTable();
				
				response2.add(truck);
			}
		} 
		catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return response;
	}

}
