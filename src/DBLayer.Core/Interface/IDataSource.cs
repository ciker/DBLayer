﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer.Core.Interface
{
    public interface IDataSource
    {
        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
        ConnectionString ConnectionString { set; get; }

        /// <summary>
        /// Gets or sets the db provider.
        /// </summary>
        /// <value>The db provider.</value>
        IDbProvider DbProvider { set; get; }

    }
}
