﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_Monitor.Classes.Step_Programs {
    public struct VariableResult {
        string name;
        public string Name {
            get { return name; }
        }
        string value;
        public string Value {
            get { return value; }
        }
        bool variableValid;
        public bool IsValid {
            get { return variableValid; }
        }
        int index = -1;
        public int Index {
            get { return index; }
            set { index = value; }
        }
        VariableScope scope = VariableScope.Global;
        public VariableScope Scope {
            get { return scope; }
            set { scope = value; }
        }
        public VariableResult(string Name, string Value, VariableScope Scope, int Index) {
            this.name = Name;
            this.value = Value;
            variableValid = true;
            this.scope = Scope;
            this.index = Index;
        }
        public VariableResult(string Name, string Value) {
            this.name = Name;
            this.value = Value;
            variableValid = true;
        }
        public VariableResult(string Name) {
            this.name = Name;
            this.value = "";
            variableValid = false;
            this.scope = VariableScope.None;
        }
    }
    public enum VariableScope {
        Global = 0x00,
        Local = 0x01,
            None = 0xFF
    }
}
