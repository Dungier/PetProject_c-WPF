   M S B A M L   `   `   `  ����G  CCursachDBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CursachDBapp.FormsCursachDBapp.Forms  5   	   #    CursachDBapp.Forms.DealsLists   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CursachDBapp.Forms     5   	     � Title$  
DealsLists��5   	   $	��450��6   $
��1400��6)    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5
   	   ���#124566 � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ ListViewDeals��5      $��10,0,145,10q�6*   
�������$��10(�6Q   
����ح� �� View 5      �� 5      .P�5      �� -   5        
DealID��$��Номер сделки��5   ]    �� Width$ 80��6s    �� DisplayMemberBinding 65   �� *DealID+6s   �� 5      -   5        DealDate��$��Дата сделки��5   a   $ 80��6v    67   �� *
DealDate+6v   �� 5      -   5        CarPrice��$��Сумма сделки��5   a   $ 80��6w    67   �� *
CarPrice+6w   �� 5      -   5        	CarID��$5��/Идентификатор автомобиля��5   [   $	 140��6}    64   �� *CarID+6}   �� 5      -   5        CarName��$3��-Наименование автомобиля��5   _   $	 140��6�    66   �� *	CarName+6�   �� 5      -   5        CompanySypplier��$��Поставщик��5   o   $ 80��6�    6>   �� *CompanySypplier+6�   �� 5      -   5        CompanySypplierCountry��$%��Страна поставщик��5   o   $	 100��6�    6E   �� *
CarPrice+6�   �� 5      -	   5        	EmpSeller��$��Сотрудник��5   c   $ 80��6v    68   �� *	EmpSeller+6v   �� 5      -
   5        EmpSellerStatus��$-��'Должность сотрудника��5   o   $	 120��6�    6>   �� *EmpSellerStatus+6�   �� 5      -   5        
Client��$��Покупатель��5   ]   $ 80��6q    65   �� *Client+6q   �� 5      -   5        
Notary��$+��%Компания заверитель��5   ]   $	 120��6z    65   �� *Notary+6z   �� 5      -   5        AmountOfTaxa��$"��Налог от сделки��5   i   $	 120��6�    6;   �� *AmountOfTaxa+6�   5      5      �� 5    
   -   5         ��Name$ button1��5       $��Закрыть��6"   $
��Left=�64   $��30��6O   $��4,0,0,0q�6[   $��1260,410,0,0q�6m   $	��Top=�6�   $	��130��6�   ���#ff8138
�������
�������	 J� RenderTransformOrigin$	 0.468,1.567&�6�   
 � 	Resources
 5!       �� 
TargetType �� Property �� Value��%^   '��       �� 5"      " ��6   .�5#      ��  �@��CornerRadius$ 8��65   5$      5%      5&      5'      5(      