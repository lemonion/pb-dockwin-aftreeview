///@file
///
/// @par Copyright © 2008 OSI Software, Inc.
/// All rights reserved.\n\n
/// <B>Unpublished</B> - rights reserved under the copyright law of the United
/// States.  Use of A copyright notice is precautionary only and does not imply
/// publication or disclosure.\n\n
/// This software contains confidential information and trade secrets of OSI
/// Software, Inc. use, disclosure, or reproduction is prohibited without the
/// prior express written permission of OSI Software, Inc.
///
/// @par Restricted rights legend
/// Use, duplication, or disclosure by the Government is subject to
/// restrictions as set forth in subparagraph (c)(1)(ii) of the Rights in
/// Technical Data and Computer Software clause at DFARS 252.227.7013
/// \n\n
/// <A href=http://www.OSIsoft.com>OSI Software, Inc.</A>
/// 777 Davis St., San Leandro CA 94577
/// \n\n
// Modification history at bottom of file.

using System;
using PBObjLib;
using PBSymLib;
using Extensibility;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PB_DockWin_AFTreeView
{

    [GuidAttribute("9F2810C7-4559-49dd-89C4-780C4431492E"), ProgId("PB_DockWin_AFTreeView.Connect")]
    public class Connect : IDTExtensibility2, IDisposable
    {
        private PBObjLib.Application m_theApp = null;
        
        #region docking window
        private PBObjLib.PBDockWindow m_dockWindow = null;
        #endregion

        public Connect()
        {
        }

        public void Dispose()
        {
        }

        public void OnConnection(object Application, Extensibility.ext_ConnectMode ConnectMode, object AddInInst, ref System.Array custom)
        {
            try
            {
                m_theApp = (PBObjLib.Application)Application;

                #region docking window

                // add docking window to PI ProcessBook application
                m_dockWindow = m_theApp.DockWindows.Add(PBObjLib.pbDockWindowType.pbTypeSingleViewWindow,
                    "AFTreeView Docking Window", PBObjLib.pbDockPosition.pbDockLeft, false);

                if (m_dockWindow != null)
                {
                    m_dockWindow.Visible = true;

                    //ensure the tree view is fully visible
                    m_dockWindow.Width = 250;

                    //create a view in the docking window to contain the control
                    PBObjLib.PBControlView ctrlView = (PBObjLib.PBControlView)m_dockWindow.
                        Views.Add(PBObjLib.pbViewType.pbControlViewType);

                    // Add the AFTreeView user control to the view in the docking window
                    AFTreeControl treeControl = (AFTreeControl)ctrlView.CreateControl("PB_DockWin_AFTreeView.AFTreeControl");
                    treeControl.app = m_theApp;
                }

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in OnConnection=" + ex.Message);
            }
        }

        public void OnDisconnection(Extensibility.ext_DisconnectMode RemoveMode, ref System.Array custom)
        {
            #region docking window
            Marshal.ReleaseComObject(m_dockWindow);
            #endregion

            System.GC.Collect();
        }

        public void OnAddInsUpdate(ref System.Array custom)
        {
        }

        public void OnBeginShutdown(ref System.Array custom)
        {
        }

        public void OnStartupComplete(ref System.Array custom)
        {
        }
         
    }
}

/************************************************************************
 * ------------------------------------------------------------------------
 * REVISION HISTORY
 *
 *   $Author: Daphne Ng
 *   $Revision: 1
 *   $Modtime: 6/12/2015
 *   $Date: 6/12/2015
 *   $Author: Daphne Ng
 * -------------------------------------------------------------------------
 *
 *   $Log: $
 **************************************************************************/