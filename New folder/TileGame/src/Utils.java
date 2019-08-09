
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is full of helper functions for the entire game
	 * 	for clarity, the world.txt file contaions two number in the first row, these are the dimensions of the world
	 * 		the second row cotains the spawn point for the entity
	 * 			the following numbers are all for the tiles of the world (they are ID numbers) 
 What I learned:
 	 * how to use a string builder
 	 * 
 Difficulties:  
	 * i usually use readers for reading text, this was my first time using a bufferedreader
 */
import java.io.*;
public class Utils {
	public static String loadFileAsString(String path)
	{
		StringBuilder builder = new StringBuilder();
		try{
			BufferedReader br = new BufferedReader(new FileReader(path));//read a file at the specified path
			String line;//the current line of the file
			
			//while there is still text in the document
			while((line = br.readLine()) != null)
			{
				builder.append(line+"\n");//add each line to the builder
				
			}
			br.close();//close the file stream
			
		}catch(IOException e){
			e.printStackTrace();//print the error to the console if the file isnt there
		}
		
		return builder.toString();
	}
	
	
	public static int parseInt(String number){
		//this takes in a string and converts it into an int
		
		try{
			return Integer.parseInt(number);//the string converted to an int
		}
		
		//if the text cant be converted
		catch (NumberFormatException e)
		{
			e.printStackTrace();
			return 0;
		}
	}
}

