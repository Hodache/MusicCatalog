   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:MusicCatalog.Views.CreationWindows"MusicCatalog.Views.CreationWindows  5   	   B    <MusicCatalog.Views.CreationWindows.ExistingTrackChoiceWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   <local0clr-namespace:MusicCatalog.Views.CreationWindows  5   	     � Title$@  :Добавление существующего трека��5	   	   $	��116��60   $	��146��6=    � 
ResizeMode$ NoResize=�6I    � SizeToContent$ WidthAndHeight=�6_   .��5
      � .+�5   
   �� $��Добавить��6j   $
��Left=�6}   $��57,60,10,10q�6�   $	��Top=�6�   $��73��6�   ��6   �� *AddToAlbumCommand+{�67   �� *AddToAlbumCommand.CanExecute+6�   �� 5   
    �� DisplayMemberPath$ Title��62   $
��Left=�6�   $��10,33,10,10q�6�   $	��Top=�6�   $	��120��6�    �� 
IsEditable$
 True��6�    �� StaysOpenOnEdit$
 True��6�   ��6   �� *Tracks+ �� SelectedItem 6L   �� *SelectedTrack+ �� Text 6s   �� *TrackSearchText+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5      	   	EventName$	 DropDownOpened��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase
   Actions.
 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *UpdateTracksListCommand+5      5      �� 5   
   $
��Left=�6   $��10,17,10,10q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q    � Language$ ru-ru�6u   $)�#Поиск и выбор трека��6�   6�   5      5      