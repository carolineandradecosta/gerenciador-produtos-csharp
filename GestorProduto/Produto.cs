﻿using System;
using System.Collections.Generic;


class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Produto(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}
