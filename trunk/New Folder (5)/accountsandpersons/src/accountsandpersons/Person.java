/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package accountsandpersons;

import javax.swing.JOptionPane;

/**
 *
 * @author jpj5048
 */
public class Person {

    static String name;
    static String idNum;

    public Person(String inName, String inIdNum){
        name = inName;
        idNum = inIdNum;

    }

    public Person(){
        name = name = FileReader.c;
        /*idNum = JOptionPane.showInputDialog("Owner's id number = ");*/
    }

    public void display (){
        JOptionPane.showMessageDialog(null,"Name = " + name + '\n');
              /* + "Id number = " + idNum);*/
        

    }
    public String getName (){
            return name;
        }

}
