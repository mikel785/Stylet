﻿using System;

namespace Stylet.Samples.MasterDetail;

public class EmployeeModel : PropertyChangedBase
{
    private string _name;
    public string Name
    {
        get => this._name;
        set => this.SetAndNotify(ref this._name, value);
    }
}
