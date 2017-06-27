﻿using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace GlossaryManager {

	partial class GlossaryManagerUI	{

		private IContainer components = null;
		
		protected override void Dispose(bool disposing)	{
			if( disposing ) {
				if( components != null ) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		internal ComponentResourceManager resources;
		
		private void InitializeComponent() {
      this.resources = new ComponentResourceManager(typeof(GlossaryManagerUI));

			this.SuspendLayout();

			// MappingControlGUI

			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.Name                = "GlossaryManagerUI";
			this.Size                = new System.Drawing.Size(994, 584);

      this.createTabControl();

			this.ResumeLayout(false);
		}

    public BusinessItemTabPage BusinessItems { get; private set; }
    public DataItemTabPage     DataItems     { get; private set; }

    private void createTabControl() {
			TabControl tabs = new TabControl () {
        Alignment     = TabAlignment.Top,
        Dock          = DockStyle.Fill,
			  Appearance    = TabAppearance.FlatButtons,
        SelectedIndex = 0,
        Padding       = new System.Drawing.Point(15, 7)
      };
      
			this.BusinessItems = new BusinessItemTabPage(this);
      tabs.Controls.Add( this.BusinessItems );
      this.DataItems = new DataItemTabPage(this);
			tabs.Controls.Add( this.DataItems );

			this.Controls.Add(tabs);
    }
    
  }
}