package pfinal;
import javax.swing.*;
import pfinal.*;
import java.io.*;

/**
 *
 * @author Camilo
 */
public class Final {
    public static Ven1 inicio = new Ven1();
    public static Ven2 ventas = new Ven2();
    public static Ven3 compras = new Ven3();
    public static int dia = 1;
    public static FileWriter Es_arc = null;
    public static PrintWriter Es_lin = null;
    
    public static void main(String[] args) {
        try{
            ven1();
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error general es:"+ e);
        }
    }
    
    public static void ven1(){
        try{
            ventas.setVisible(false);
            compras.setVisible(false);
            inicio.setTitle("Bienvenido");
            inicio.setLocationRelativeTo(null);
            inicio.setVisible(true);
            Ven1.L_Dia.setText(String.valueOf(dia));
            Ven2.L_Dia.setText(String.valueOf(dia));
            Ven3.L_Dia.setText(String.valueOf(dia));
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error para mostrar la ventana inicio es:"+ e);
        }
    }
    
    public static void ven2(){
        try{
            inicio.setVisible(false);
            compras.setVisible(false);
            Ven2.mostrar.setVisible(false);
            ventas.setTitle("Ventas");
            ventas.setLocationRelativeTo(null);
            ventas.setVisible(true);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error para mostrar la ventana ventas es:"+ e);
        }
    }
    
    public static void ven3(){
        try{
            inicio.setVisible(false);
            ventas.setVisible(false);
            compras.setTitle("Compras");
            compras.setLocationRelativeTo(null);
            compras.setVisible(true);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error para mostrar la ventana compras es:"+ e);
        }
    }
    
}