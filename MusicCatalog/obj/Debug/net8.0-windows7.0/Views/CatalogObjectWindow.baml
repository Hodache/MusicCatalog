   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MusicCatalog.ViewsMusicCatalog.Views  5   	   ,    &MusicCatalog.Views.CatalogObjectWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MusicCatalog.Views     5   	     � Title$#  Объект каталога��5   	   $	��230��6!   $	��198��6.    � 
ResizeMode$ NoResize=�6:    � SizeToContent$ WidthAndHeight=�6P   .��5	      � .+�5
   
   �� -   5         ��Name$ objectTypeTextBlock��5
      $
��Left=�61   $��10,10,10,10q�6L   $
��Wrap=�6a   $	��Top=�6u   �� 6�    � Language$ ru-ru�6�   �6�   �� **(DisplayedCatalogObject.CatalogObjectType+ �� Mode$ OneTime=�6�   �� 5   
   -   5        $ objectNameTextBlock��5      $
��Left=�61   $��10,26,10,10q�6L   $
��Wrap=�6a   $	��Top=�6u   $
��Bold"�6�   �� 6�   $ ru-ru�6�   �6�   �� *$"DisplayedCatalogObject.Designation+$ OneTime=�6�   �� 5   
   -   5        $ objectInfoOneTextBlock��5      $
��Left=�64   $��
10,42,10,0q�6O   $
��Wrap=�6c   $	��Top=�6w   �� 6�   $ ru-ru�6�   �6�   �� *" DisplayedCatalogObject.FirstInfo+$ OneTime=�6�   �� 5   
   -   5        $ objectInfoTwoTextBlock��5      $
��Left=�64   $��10,58,10,10q�6O   $
��Wrap=�6d   $	��Top=�6x   �� 6�   $ ru-ru�6�   �6�   �� *#!DisplayedCatalogObject.SecondInfo+$ OneTime=�6�   �� 5   
   $��10,107,10,10q�6a   $	��178��6w   $��97��6�   ��6   �� **(DisplayedCatalogObject.AssociatedObjects+$ OneTime=���5      �� 5      .R�5      �� ��6    �� *Designation+$ OneTime=�5      5      �� 5   
   -   5        $ objectAssociatedTextBlock��5      $��Center=�67   $
��Wrap=�6T   $	��Top=�6h   $	��178��6�   $��0,91,0,0q�6�   �� 6�   $ ru-ru�6�   �6�   �� *(&DisplayedCatalogObject.AssociatedLabel+$ OneTime=�6�   5      5      