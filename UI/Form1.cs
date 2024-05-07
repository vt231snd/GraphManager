﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibraryGraph;
using static System.Windows.Forms.LinkLabel;

namespace UI
{
    enum Mode
    {
        AddVertex,
        AddEdge,
        Select
    }
    public partial class Field : System.Windows.Forms.Form
    {
        private Mode mode = Mode.Select;
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();
        private Graphics graphics;
        private bool isCtrlPressed = false;
        private int lastAddedVertNumber = 0;
        public Field()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Field_KeyDown);
            this.KeyUp += new KeyEventHandler(Field_KeyUp);
        }
        private void render()
        {
            graphics.Clear(pictureBox1.BackColor);
            foreach (Edge e in edges) e.draw();
            foreach (Vertex v in vertices) v.draw();
        }
        private Vertex getVertexByPoint(Point point)
        {
            foreach (Vertex v in vertices)
            {
                if (v.isPointOnVertex(point.X, point.Y)) return v;
            }
            return null;
        }
        private void addVertex(Point point)
        {
            var vertex = new Vertex(point.X, point.Y, lastAddedVertNumber + 1, graphics);

            foreach (var vert in vertices)
            {
                if (vert.isOverlapingWithVertexInPoint(point.X, point.Y)) return;
            }

            lastAddedVertNumber++;
            vertices.Add(vertex);
        }
        private void addEdge(Point point)
        {
            Vertex firstVertex = null;

            firstVertex.draw();

            foreach (var v in vertices) 
                if (v.IsSelected)
                {
                    firstVertex = v;
                    break;
                }

            if (firstVertex == null)
            { 
                firstVertex = getVertexByPoint(point);
                if(firstVertex != null) firstVertex.IsSelected = true;
                return;
            }

            Vertex secondVertex = getVertexByPoint(point);
            if (secondVertex == null) return;

            Edge edge = new Edge(firstVertex, secondVertex, graphics);
            edges.Add(edge);

            firstVertex.IsSelected = false;
            render();
        }
        private void selectElement(Point point, bool isSelectMultiple)
        {
            var exitingVertex = getVertexByPoint(point);

            if (exitingVertex == null)
            {
                foreach (var vert in vertices) vert.IsSelected = false;
                return;
            }


            if(!isSelectMultiple)
            {
                foreach (var vert in vertices) vert.IsSelected = false;
            }

            if(!exitingVertex.IsSelected) exitingVertex.IsSelected = true;
            else
            {
                exitingVertex.IsSelected = false;
            }
        }
        private void Field_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && !isCtrlPressed) isCtrlPressed = true;
        }
        private void Field_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control && isCtrlPressed) isCtrlPressed = false;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;

            if (mode == Mode.Select) selectElement(point, isCtrlPressed);

            if (mode == Mode.AddVertex) addVertex(point);
            
            if (mode == Mode.AddEdge) addEdge(point);

            render();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<Vertex> verticesToRemove = new List<Vertex>();

            foreach(var vert in vertices)
            {
                if (!vert.IsSelected) continue;
                verticesToRemove.Add(vert);
            }
            foreach (var vrt in verticesToRemove) vertices.Remove(vrt);
            render();
        }
        private void buttonAddVertex_Click(object sender, EventArgs e)
        {
            mode = Mode.AddVertex;
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            mode = Mode.Select;
        }
        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            mode = Mode.AddEdge;
            foreach (var vert in vertices) vert.IsSelected = false;
            render();
        }
    }
}
