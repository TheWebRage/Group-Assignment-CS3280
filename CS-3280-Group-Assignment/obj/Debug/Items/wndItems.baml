   M S B A M L   `   `   `  ����S  OCS-3280-Group-Assignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CS_3280_Group_Assignment.ItemsCS_3280_Group_Assignment.Items  5   	   C&clr-namespace:CS_3280_Group_AssignmentCS_3280_Group_Assignment  5   	   -    'CS_3280_Group_Assignment.Items.wndItems   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CS_3280_Group_Assignment.Items     5   	   KCS_3280_Group_Assignment&clr-namespace:CS_3280_Group_Assignment     5   	     � Title$  InvoiceItems��5	   	   $	��450��6   $	��800��6+    � 	Resources 5
      5   /CS_3280_Group_Assignment.InvoiceDatabaseDataSet   invoiceDatabaseDataSet  itemsViewSource �� Source �� Source��%V   &	        &	      7     5   
   6:   �� 5   
    67   �� *Items+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ itemsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��94,25,85.333,129.667q�6}      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6e   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        itemIDColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Item ID��5   V      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ItemID+6g     5      -   5        itemNameColumn��$
 	Item Name��5   Z   $	 300 6m    6=   �� *
ItemName+6m     5      -   5        itemCostColumn��$
 	Item Cost��5   Z   $	 150 6m    6=   �� *
ItemCost+6m   5      �� 5   
   -   5         ��Name$ 
btnAddItem��5      $��Add Item��6%   $
��Left=�68   $��197,372,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ btnEditItem��5      $��	Edit Item��6&   $
��Left=�6:   $��352,372,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $ btnDeleteItem��5      $��Delete Item��6(   $
��Left=�6>   $��514,372,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5   
   -   5         ��Name$ 
tbItemName��5      $
��Left=�6&   $��23��6A   $��197,336,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��234��6�   �� 5   
   -	   5        $ 
tbItemCost��5      $
��Left=�6&   $��23��6A   $��497,336,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $��92��6�   �� 5   
   -
   5         ��Name$ lblItemName��5      $��
Item Name:��6%   $
��Left=�6:   $��197,305,0,0q�6U   $	��Top=�6j   $	��230��6�   �� 5   
   -   5        $ lblItemCost��5      $��
Item Cost:��6%   $
��Left=�6:   $��497,305,0,0q�6U   $	��Top=�6j   $��92��6�   5      5       