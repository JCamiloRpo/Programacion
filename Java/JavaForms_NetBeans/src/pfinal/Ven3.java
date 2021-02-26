package pfinal;
import java.io.*;
import javax.swing.*;
import javax.swing.table.*;
/**
 *
 * @author Camilo
 */
public class Ven3 extends javax.swing.JFrame {
    
    public Ven3() {
        initComponents();
        TBM = (DefaultTableModel)TB_Compras.getModel();
    }
    

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        TB_Compras = new javax.swing.JTable();
        B_Llenar = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();
        L_Dia = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);

        TB_Compras.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Tanque 1", "Tanque 2", "Tanque 3", "Tanque 4", "Tanque 5", "Tanque 6", "Tanque 7", "Tanque 8", "Tanque 9"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false, false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(TB_Compras);
        if (TB_Compras.getColumnModel().getColumnCount() > 0) {
            TB_Compras.getColumnModel().getColumn(0).setResizable(false);
            TB_Compras.getColumnModel().getColumn(1).setResizable(false);
            TB_Compras.getColumnModel().getColumn(2).setResizable(false);
            TB_Compras.getColumnModel().getColumn(3).setResizable(false);
            TB_Compras.getColumnModel().getColumn(4).setResizable(false);
            TB_Compras.getColumnModel().getColumn(5).setResizable(false);
            TB_Compras.getColumnModel().getColumn(6).setResizable(false);
            TB_Compras.getColumnModel().getColumn(7).setResizable(false);
            TB_Compras.getColumnModel().getColumn(8).setResizable(false);
        }

        B_Llenar.setText("Llenar");
        B_Llenar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_LlenarActionPerformed(evt);
            }
        });

        jLabel9.setText("Día");

        L_Dia.setText("0");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jLabel9)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(L_Dia, javax.swing.GroupLayout.PREFERRED_SIZE, 17, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(B_Llenar)
                .addGap(30, 30, 30))
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 541, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel9)
                    .addComponent(L_Dia))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 91, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 9, Short.MAX_VALUE)
                .addComponent(B_Llenar)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void B_LlenarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_LlenarActionPerformed
        try{
            Final.Es_arc = new FileWriter("C:/Users/Camilo/Documents/Ventas y Compras.txt",true);
            Final.Es_lin = new PrintWriter(Final.Es_arc);
            c ++;
            if(Final.dia<=10)Final.Es_lin.println("  Reporte de compra numero "+c);
            for (int i=0;i<9;i++) {
                if(i>=0 && i<3)Ven2.Vsus[i]=500000d;
                else if(i>=3 && i<7)Ven2.Vsus[i]=550000d;
                else if(i>=7 && i<9)Ven2.Vsus[i]=2800000d;
                if(Final.dia<=10){
                    if(Double.parseDouble(TB_Compras.getValueAt(0,i).toString())!=0d)
                        Final.Es_lin.println("      Se compró: "+TB_Compras.getValueAt(0,i).toString()+" del tanque "+(i+1));
                }
            }
            if(Final.dia<=10){
                Final.Es_lin.println();
                Final.Es_lin.println();
            }
            TBM.removeRow(0);
            Final.ven2();
        }
        catch(IOException e){
            JOptionPane.showMessageDialog(null,"El error de apertura de la ventana 2 es "+e);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error boton llenar es:"+ e);
        }
        finally{
            try {
                Final.Es_lin.close();
            } catch (Exception e) {
                JOptionPane.showMessageDialog(null,"El error de cierre es "+e);
            }
        }
    }//GEN-LAST:event_B_LlenarActionPerformed

    public static int c = 0;
    public static DefaultTableModel TBM;

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton B_Llenar;
    public static javax.swing.JLabel L_Dia;
    private javax.swing.JTable TB_Compras;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}