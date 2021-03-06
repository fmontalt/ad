﻿using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;
using Serpis.Ad;
using CArticulo;


public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        App.Instance.Connection = new MySqlConnection("server=localhost;database=dbprueba;user=root;password=sistemas");
        App.Instance.Connection.Open();

        TreeViewHelper.Fill(treeView, ArticuloDao.SelectAll);

        treeView.Selection.Changed += delegate
        {
            bool hasSelected = treeView.Selection.CountSelectedRows() > 0;
        };

        newAction.Activated += delegate
        {
            Articulo articulo = new Articulo();
            new ArticuloWindow(articulo);
        };

        editAction.Activated += delegate
        {
            object id = TreeViewHelper.GetId(treeView);
            Articulo articulo = ArticuloDao.Load(id);
            new ArticuloWindow(articulo);
        };

        refreshAction.Activated += delegate
        {
            TreeViewHelper.Fill(treeView, ArticuloDao.SelectAll);
        };

        deleteAction.Activated += delegate
        {
            if (WindowHelper.Confirm(this, "¿Quieres eliminar el registro?"))
            {
                object id = TreeViewHelper.GetId(treeView);
                ArticuloDao.Delete(id);
            }
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        App.Instance.Connection.Close();
        Application.Quit();
        a.RetVal = true;
    }

}