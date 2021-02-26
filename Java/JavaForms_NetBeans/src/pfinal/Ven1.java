package pfinal;

import java.io.*;
import javax.swing.*;
/**
 *
 * @author Camilo
 */
public class Ven1 extends javax.swing.JFrame {

    public Ven1() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel9 = new javax.swing.JLabel();
        L_Dia = new javax.swing.JLabel();
        B_Aceptar = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));

        jLabel9.setFont(new java.awt.Font("Tahoma", 0, 36)); // NOI18N
        jLabel9.setText("Día");

        L_Dia.setFont(new java.awt.Font("Tahoma", 0, 36)); // NOI18N
        L_Dia.setText("0");

        B_Aceptar.setText("Aceptar");
        B_Aceptar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_AceptarActionPerformed(evt);
            }
        });

        jLabel1.setBackground(new java.awt.Color(0, 0, 255));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(61, 61, 61)
                .addComponent(jLabel9)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(L_Dia, javax.swing.GroupLayout.DEFAULT_SIZE, 67, Short.MAX_VALUE)
                .addGap(18, 18, 18)
                .addComponent(B_Aceptar)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 140, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jLabel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(34, 34, 34)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel9)
                            .addComponent(L_Dia)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(44, 44, 44)
                        .addComponent(B_Aceptar)))
                .addGap(0, 38, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void B_AceptarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_AceptarActionPerformed
        if(Final.dia==1){
            try{
                Final.Es_arc = new FileWriter("C:/Users/Camilo/Documents/Ventas y Compras.txt");
                Final.Es_lin = new PrintWriter(Final.Es_arc);
                Final.Es_lin.println("Día "+Final.dia);
                Final.Es_lin.println("  Contenido inicial de tanques");
                for (int i=0;i<9;i++) {
                    if(i>=0 && i<3){
                        Ven2.Vsus[i]=500000d;
                        Final.Es_lin.println("      Tanque: "+(i+1)+" contiene: "+Ven2.Vsus[i]);
                    }
                    else if(i>=3 && i<7){
                        Ven2.Vsus[i]=550000d;
                        Final.Es_lin.println("      Tanque: "+(i+1)+" contiene: "+Ven2.Vsus[i]);
                    }
                    else if(i>=7 && i<9){
                        Ven2.Vsus[i]=2800000d;
                        Final.Es_lin.println("      Tanque: "+(i+1)+" contiene: "+Ven2.Vsus[i]);
                    }
                }
                Final.Es_lin.println();
                Final.Es_lin.println();
            }
            catch(IOException e){
                JOptionPane.showMessageDialog(null,"El error de apertura de la ventana inicio es "+e);
            }
            catch(Exception e){
                JOptionPane.showMessageDialog(null,"El error del boton abrir es:"+ e);
            }
            finally{
                try {
                    Final.Es_lin.close();
                } catch (Exception e) {
                    JOptionPane.showMessageDialog(null,"El error de cierre de la ventana 1 es "+e);
                }
            }
        }
        else if(Final.dia>=2 && Final.dia<=10){
            try{
                Final.Es_arc = new FileWriter("C:/Users/Camilo/Documents/Ventas y Compras.txt",true);
                Final.Es_lin = new PrintWriter(Final.Es_arc);
                Final.Es_lin.println("-----------------------------------------");
                Final.Es_lin.println("Día "+Final.dia);
                Final.Es_lin.println("  Contenido inicial de tanques");
                for (int i=0;i<9;i++) {
                    Ven2.Vsus[i]=(double)Ven2.Vsus[i]*0.995;
                    Final.Es_lin.println("      Tanque: "+(i+1)+" contiene: "+Ven2.Vsus[i]);
                }
                Final.Es_lin.println();
                Final.Es_lin.println();
            }
            catch(IOException e){
                JOptionPane.showMessageDialog(null,"El error de apertura de la ventana inicio es "+e);
            }
            catch(Exception e){
                JOptionPane.showMessageDialog(null,"El error del boton abrir es:"+ e);
            }
            finally{
                try {
                    Final.Es_lin.close();
                } catch (Exception e) {
                    JOptionPane.showMessageDialog(null,"El error de cierre de la ventana 1 es "+e);
                }
            }
        }
        else{
            if(JOptionPane.showConfirmDialog(null,"Han pasado 10 dias, si continua el programa dejará de escribir el archivo \n desea continuar?")
                    ==JOptionPane.YES_OPTION){
                for (int i=0;i<9;i++) {
                    Ven2.Vsus[i]=(double)Ven2.Vsus[i]*0.995;
                }
            }
            else System.exit(0);
        }
        Final.ven2();
    }//GEN-LAST:event_B_AceptarActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton B_Aceptar;
    public static javax.swing.JLabel L_Dia;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel9;
    // End of variables declaration//GEN-END:variables
}