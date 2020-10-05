﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VisitNow.CustomControl
{
    public class MaskedLabelBehavior : Behavior<Label>
    {
        private string _mask = "";
        public string Mask
        {
            get => _mask;
            set
            {
                _mask = value;
                SetPositions();
            }
        }

        protected override void OnAttachedTo(Label label)
        {
            label.PropertyChanged += OnLabelPropertyChanged;
            base.OnAttachedTo(label);
        }

        protected override void OnDetachingFrom(Label label)
        {
            label.PropertyChanged += OnLabelPropertyChanged;
            base.OnDetachingFrom(label);
        }

        IDictionary<int, char> _positions;

        void SetPositions()
        {
            if (string.IsNullOrEmpty(Mask))
            {
                _positions = null;
                return;
            }

            var list = new Dictionary<int, char>();
            for (var i = 0; i < Mask.Length; i++)
                if (Mask[i] != 'X')
                    list.Add(i, Mask[i]);

            _positions = list;
        }

        private void OnLabelPropertyChanged(object sender, EventArgs e)
        {
            var label = sender as Label;

            var text = label.Text;

            if (string.IsNullOrWhiteSpace(text) || _positions == null)
                return;

            if (text.Length > _mask.Length)
            {
                label.Text = text.Remove(text.Length - 1);
                return;
            }

            foreach (var position in _positions)
                if (text.Length >= position.Key + 1)
                {
                    var value = position.Value.ToString();
                    if (text.Substring(position.Key, 1) != value)
                        text = text.Insert(position.Key, value);
                }

            if (label.Text != text)
                label.Text = text;
        }
    }
}
