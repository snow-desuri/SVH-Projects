   M S B A M L   `   `   `  ����L  HΣngineMainWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ΣngineMainWindowΣngineMainWindow  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   "    ΣngineMainWindow.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ΣngineMainWindow     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Σngine��5	   	   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V    � Icon$ sigmavh2_large.png��6l   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��548* �6   �� 5      $
��247* �6   .+�5   
   �� $
��Left=�6   $	��401��60   $��	10,10,0,0q�6=   $	��Top=�6P   $	��774��6h   $��2��6t   .@�5      �� $��	Executive��6   .��5      � $��
-17,0,17,0q�6   ��5      �� 5       �� ImageSource$, &512px-890_Jump_Leaving_Hurston_3.6.png��6%    5      �� 5      $	��17* �6+   �� 5      $
��111* �6+   .+�5      �� -   5         ��Name$
 sync��5   3   $��Synchronize��6   $
��Left=�6A   $��	10,17,0,0q�6\   $	��Top=�6o   $��75��6�   {�.  6�   �� 5      -   5        $ contacts��5   0   $��Contacts��6   $
��Left=�6B   $��	10,42,0,0q�6]   $	��Top=�6p   $��75��6�   6�   �� 5      -   5        $ members��5   /   $��Members��6   $
��Left=�6@   $��	10,67,0,0q�6[   $	��Top=�6n   $��75��6�   {�.  6�   �� 5      -   5        $ briefs��5   .   $��Briefs��6   $
��Left=�6>   $��	10,92,0,0q�6Y   $	��Top=�6l   $��76��6�   6�   �� 5      -   5        $ investments��5   3   $��Investments��6   $
��Left=�6H   $��
11,335,0,0q�6c   $	��Top=�6w   $��75��6�   {�.  6�   �� 5      -   5         ��Name$ contactlisting��5   .   $��1��6   $
��Left=�6F   $	��351��6a   $��
396,12,0,0q�6n   $	��Top=�6�   $	��260��6�   $y�Hidden=�6�   �� 5      -   5        $ addcontactbutton��5   7   $��Add New Contact��6   $��1��6Q   $
��Left=�6a   $��
288,12,0,0q�6|   $	��Top=�6�   $	��102��6�   $y�Hidden=�6�   �� 5       -   5         ��Name$ contactname��5    b   $��Contact Name��6   $��1��6R   $
��Left=�6w   $��23��6�   $��
271,53,0,0q�6�   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��119��6�   

 � Tag$
  ��6�    � ToolTip$ Contact Name��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Contact Name��6  $y�Hidden=�65  �� 5!      -	   5        $ 	rsihandle��5!   ^   $��
RSI Handle��6   $��1��6N   $
��Left=�6q   $��23��6�   $��
271,89,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��119��6�   $y�Hidden=�6�   �� 5"      $��1��6   $
��Left=�6/   $	��296��6J   $��	10,67,0,0q�6W   $	��Top=�6j   $	��646��6�   $y�Hidden=�6�    �� View 5#      �� 5$      .P�5%   "   �� �� 5&   "   5'      5)      �� 5*      $��	Add Entry��6   $��1��61   $
��Left=�6A   $��	10,42,0,0q�6\   $	��Top=�6o   $��75��6�   $y�Hidden=�6�   �� 5+      $��Delete Entry��6   $��1��64   $
��Left=�6D   $��	90,42,0,0q�6_   $	��Top=�6r   $��75��6�   $y�Hidden=�6�   �� 5,      $0��**Double click an entry to view full breif.��6   $��1��6Q   $
��Left=�6a   $��
170,39,0,0q�6|   $	��Top=�6�   
�������$y�Hidden=�6�   5-      5.      �� 5/      $��Military��6   {�.  .��50      � ��51      �� 52      $ Polaris-Landed.jpg��6%   .+�54      �� $	��WAR��6   $
��Left=�6+   $��213,338,0,0q�6F   $	��Top=�6[   $��75��6s   $��25��6~   ���	#FF8D1515{�.  6�   �� 55      $��Caution��6   $
��Left=�6/   $��327,338,0,0q�6J   $	��Top=�6_   $��75��6w   $��25��6�   ���	#FFBECF126�   �� 56      $��Peace��6   $
��Left=�6-   $��443,338,0,0q�6H   $	��Top=�6]   $��75��6u   $��25��6�   ���	#FF0FE2186�   �� 57      $��CEO approval��6   $
��Left=�66   $��
91,331,0,0q�6Q   $	��Top=�6e   ���	#FFF9F9F9$��14��6�   $��96��6�   �� 58      $��Admiral Approval��6   $
��Left=�6:   $��
91,348,0,0q�6U   $	��Top=�6i   
�������$��15��6�   $	��117��6�   59      5:      �� 5;      $��Support��6   {�.  .��5<      � ��5=      �� 5>      $0 *RSI_Apollo_Flight_02a_AL_PJ01-Squashed.jpg��6%   5@      5A      �� 5B      $��
Industrial��6   {�.  .��5C      � ��5D      �� 5E      $ 
Source.jpg��6%   5G      5H      �� 5I      $��	Transport��6   {�.  .��5J      � ��5K      �� 5L      $ Hull_E_4_compflat.jpg��6%   5N      5O      �� 5P      $��Research��6   {�.  .��5Q      � ��5R      �� 5S      $! CO_Beauty_Supercollider.jpg��6%   5U      5V      �� 5W      $��Racing��6   {�.  .��5X      � ��5Y      �� 5Z      $  Misc-Razer-Pit-Crew-V4.jpg��6%   5\      5]      �� 5^      $��Special Projects��6   {�.  ��5_      �� 5`      .��5b      �  5c      �� 5d      $	��82* �6+   �� 5e      $
��687* �6+   ��5g      �� 5h      $: 4CRUS_Ares_Promo_Action_Banner_Fix_PJ04_optimized.jpg��6%   5j      5k      5l      5n      5o      