﻿using System;
using System.Data;

namespace Serpis.Ad
{
    public class App
    {
        private IDbConnection connection;
        private App()
        {
        }

        private static App instance = new App();

        //public static App GetInstance() {
        //    return instance;
        //}
        public static App Instance {
            get { return instance; }
        }

        //public IDbConnection GetConnection () {
        //    return connection;
        //}
        //public void SetConnection (IDbConnection connection) {
        //    this.connection = connection;
        //}
        public IDbConnection Connection {
            get { return connection; }
            set { connection = value; }
        }
    }
}
