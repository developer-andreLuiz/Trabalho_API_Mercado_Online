﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class DBContextDAO : DbContext
    {
        public DBContextDAO()
        {
        }

        public DBContextDAO(DbContextOptions<DBContextDAO> options)
            : base(options)
        {
        }

        public virtual DbSet<Bairro> Bairros { get; set; } = null!;
        public virtual DbSet<Carrinho> Carrinhos { get; set; } = null!;
        public virtual DbSet<CategoriaNivel1> CategoriaNivel1s { get; set; } = null!;
        public virtual DbSet<CategoriaNivel2> CategoriaNivel2s { get; set; } = null!;
        public virtual DbSet<CategoriaNivel3> CategoriaNivel3s { get; set; } = null!;
        public virtual DbSet<CategoriaNivel4> CategoriaNivel4s { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Encarte> Encartes { get; set; } = null!;
        public virtual DbSet<EncarteItem> EncarteItems { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<LocalEntrega> LocalEntregas { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<ProdutoCategorium> ProdutoCategoria { get; set; } = null!;
        public virtual DbSet<ProdutoCodigoBarra> ProdutoCodigoBarras { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=bancodados-mercado.mysql.database.azure.com;userid=root_andre;password=SistemaValendo1;database=db_mercado_online;sslmode=none;connect timeout=30", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_unicode_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Bairro>(entity =>
            {
                entity.ToTable("bairro");

                entity.HasComment("tabela com todos os bairros");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da tabela ");

                entity.Property(e => e.CodigoBairro)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_bairro")
                    .HasComment("codigo do bairro");

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_estado")
                    .HasComment("codigo do estado");

                entity.Property(e => e.CodigoMunicipio)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_municipio")
                    .HasComment("codigo do municipio");

                entity.Property(e => e.NomeBairro)
                    .HasMaxLength(255)
                    .HasColumnName("nome_bairro")
                    .HasComment("nome do bairro");
            });

            modelBuilder.Entity<Carrinho>(entity =>
            {
                entity.ToTable("carrinho");

                entity.HasComment("tabela com os dados do carrinho dos clientes");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da tabela");

                entity.Property(e => e.CodigoCliente)
                    .HasColumnType("int(11)")
                    .HasColumnName("codigo_cliente")
                    .HasComment("referencia do codigo do cliente");

                entity.Property(e => e.CodigoProduto)
                    .HasColumnType("int(11)")
                    .HasColumnName("codigo_produto")
                    .HasComment("referencia do codigo do produto");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantidade")
                    .HasComment("quantidade de itens do mesmo produto no carrinho");
            });

            modelBuilder.Entity<CategoriaNivel1>(entity =>
            {
                entity.ToTable("categoria_nivel_1");

                entity.HasComment("tabela com os dados da categoria nivel 1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da categoria nivel 1");

                entity.Property(e => e.Img)
                    .HasColumnType("text")
                    .HasColumnName("img")
                    .HasComment("url da imagem");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome")
                    .HasComment("nome da categoria nivel 1");

                entity.Property(e => e.Ordem)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordem")
                    .HasComment("ordem de exibição");
            });

            modelBuilder.Entity<CategoriaNivel2>(entity =>
            {
                entity.ToTable("categoria_nivel_2");

                entity.HasComment("tabela com os dados da categoria nivel 2");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da categoria nivel 2");

                entity.Property(e => e.CategoriaNivel1)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_1")
                    .HasComment("referencia codigo da categoria nivel 1");

                entity.Property(e => e.Img)
                    .HasColumnType("text")
                    .HasColumnName("img")
                    .HasComment("url da imgagem");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome")
                    .HasComment("nome da categoria nivel 2");

                entity.Property(e => e.Ordem)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordem")
                    .HasComment("ordem de exibição");
            });

            modelBuilder.Entity<CategoriaNivel3>(entity =>
            {
                entity.ToTable("categoria_nivel_3");

                entity.HasComment("tabela com os dados da categoria nivel 3");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da categoria nivel 3");

                entity.Property(e => e.CategoriaNivel1)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_1")
                    .HasComment("referencia do codigo da categoria nivel 1");

                entity.Property(e => e.CategoriaNivel2)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_2")
                    .HasComment("referencia do codigo da categoria nivel 2");

                entity.Property(e => e.Img)
                    .HasColumnType("text")
                    .HasColumnName("img")
                    .HasComment("url da imagem");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome")
                    .HasComment("nome da categoria nivel 3");

                entity.Property(e => e.Ordem)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordem")
                    .HasComment("ordem de exibição");
            });

            modelBuilder.Entity<CategoriaNivel4>(entity =>
            {
                entity.ToTable("categoria_nivel_4");

                entity.HasComment("tabela com os dados da categoria nivel 4");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da categoria nivel 4");

                entity.Property(e => e.CategoriaNivel1)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_1")
                    .HasComment("referencia do codigo da categoria nivel 1");

                entity.Property(e => e.CategoriaNivel2)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_2")
                    .HasComment("referencia do codigo da categoria nivel 2");

                entity.Property(e => e.CategoriaNivel3)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_3")
                    .HasComment("referencia do codigo da categoria nivel 3");

                entity.Property(e => e.Img)
                    .HasColumnType("text")
                    .HasColumnName("img")
                    .HasComment("url da imagem");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome")
                    .HasComment("nome da categoria nivel 4");

                entity.Property(e => e.Ordem)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordem")
                    .HasComment("ordem de exibição");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente");

                entity.HasComment("tabela com informações dos clientes");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da tabela e codigo de cada cliente");

                entity.Property(e => e.AparelhoId)
                    .HasMaxLength(255)
                    .HasColumnName("aparelho_id");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("cpf")
                    .HasComment("cpf do cliente");

                entity.Property(e => e.Habilitado)
                    .HasColumnType("int(11)")
                    .HasColumnName("habilitado")
                    .HasDefaultValueSql("'1'")
                    .HasComment("status do cliente");

                entity.Property(e => e.Nascimento)
                    .HasColumnType("datetime")
                    .HasColumnName("nascimento")
                    .HasComment("Data de nascimento  do cliente");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome")
                    .HasComment("nome do cliente");

                entity.Property(e => e.Saldo)
                    .HasPrecision(10, 2)
                    .HasColumnName("saldo")
                    .HasComment("saldo do cliente");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("telefone")
                    .HasComment("numero de telefone do cliente");
            });

            modelBuilder.Entity<Encarte>(entity =>
            {
                entity.ToTable("encarte");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(255)
                    .HasColumnName("data");

                entity.Property(e => e.Frente)
                    .HasColumnType("int(11)")
                    .HasColumnName("frente");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome");

                entity.Property(e => e.Tipo)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo");

                entity.Property(e => e.Validade)
                    .HasMaxLength(255)
                    .HasColumnName("validade");
            });

            modelBuilder.Entity<EncarteItem>(entity =>
            {
                entity.ToTable("encarte_item");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdEncarte)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_encarte");

                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .HasColumnName("img");

                entity.Property(e => e.Produto)
                    .HasMaxLength(255)
                    .HasColumnName("produto");

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado");

                entity.HasComment("tabela com todos os estados ");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da tabela");

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_estado")
                    .HasComment("codigo do estado");

                entity.Property(e => e.NomeEstado)
                    .HasMaxLength(255)
                    .HasColumnName("nome_estado")
                    .HasComment("nome do estado");
            });

            modelBuilder.Entity<LocalEntrega>(entity =>
            {
                entity.ToTable("local_entrega");

                entity.HasComment("tabela com objetivo de informar as localidades com entrega disponivel");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CodigoBairro)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_bairro")
                    .HasComment("codigo do bairro");

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_estado")
                    .HasComment("codigo do estado");

                entity.Property(e => e.CodigoMunicipio)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_municipio")
                    .HasComment("codigo do municipio");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.ToTable("municipio");

                entity.HasComment("tabela com todos os municipio ");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da tabela");

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_estado")
                    .HasComment("codigo do estado");

                entity.Property(e => e.CodigoMunicipio)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_municipio")
                    .HasComment("codigo do municipio");

                entity.Property(e => e.NomeMunicipio)
                    .HasMaxLength(255)
                    .HasColumnName("nome_municipio")
                    .HasComment("nome do municipio");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produto");

                entity.HasComment("tabela com os dados dos produtos");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("autonumerico chave primaria da tabela");

                entity.Property(e => e.CodigoLoja)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_loja")
                    .HasDefaultValueSql("'0'")
                    .HasComment("numero de codigo interno da loja\\n");

                entity.Property(e => e.CustoUnitario)
                    .HasColumnName("custo_unitario")
                    .HasComment("valor de custo do produto\\\\n");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .HasColumnName("descricao")
                    .HasComment("nome do produto\n");

                entity.Property(e => e.Embalagem)
                    .HasMaxLength(255)
                    .HasColumnName("embalagem")
                    .HasComment("PCT - UND - CX - PESO\n");

                entity.Property(e => e.Gramatura)
                    .HasMaxLength(255)
                    .HasColumnName("gramatura")
                    .HasComment("1,5L  - 50ml (sem espaço e maiusculo) kg - gr - lt - ml - und\n");

                entity.Property(e => e.IgualaProduto)
                    .HasColumnType("int(11)")
                    .HasColumnName("iguala_produto")
                    .HasComment("0 - 1 - 2 -3 \nserve para realizar alteração em produtos iguais");

                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .HasColumnName("img")
                    .HasComment("url -jpg\n");

                entity.Property(e => e.Informacao)
                    .HasColumnType("text")
                    .HasColumnName("informacao")
                    .HasComment("informação nutricional do produto\n");

                entity.Property(e => e.ItensCaixa)
                    .HasColumnType("int(11)")
                    .HasColumnName("itens_caixa")
                    .HasComment("quantidade de produto  na caixa\n");

                entity.Property(e => e.Peso)
                    .HasMaxLength(5)
                    .HasColumnName("peso")
                    .HasComment("01526 (01,526kg)\n");

                entity.Property(e => e.Pronuncia)
                    .HasMaxLength(255)
                    .HasColumnName("pronuncia")
                    .HasComment("leitura da descrição\n");

                entity.Property(e => e.Validade)
                    .HasColumnName("validade")
                    .HasComment("se o produto é perecivel ou nao\n");

                entity.Property(e => e.ValorPromocao)
                    .HasColumnName("valor_promocao")
                    .HasComment("valor de promoção do produto\\\\n");

                entity.Property(e => e.ValorVenda)
                    .HasColumnName("valor_venda")
                    .HasComment("valor de venda do produto\\\\n");

                entity.Property(e => e.Volume)
                    .HasColumnType("int(11)")
                    .HasColumnName("volume")
                    .HasComment("30 - caixa volume =100 (cabe 3 na caixa)volume do produto\n");
            });

            modelBuilder.Entity<ProdutoCategorium>(entity =>
            {
                entity.ToTable("produto_categoria");

                entity.HasComment("tabela com os dados dos produtos relacionando com as categorias");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("autonumerico chave primaria da tabela");

                entity.Property(e => e.CategoriaNivel1)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_1")
                    .HasComment("referecia a categoria nivel 1");

                entity.Property(e => e.CategoriaNivel2)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_2")
                    .HasComment("referecia a categoria nivel 2");

                entity.Property(e => e.CategoriaNivel3)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_3")
                    .HasComment("referecia a categoria nivel 3");

                entity.Property(e => e.CategoriaNivel4)
                    .HasColumnType("int(11)")
                    .HasColumnName("categoria_nivel_4")
                    .HasComment("referecia a categoria nivel 4");

                entity.Property(e => e.CodigoProduto)
                    .HasColumnType("int(11)")
                    .HasColumnName("codigo_produto")
                    .HasComment("referencia ao codigo do produto");

                entity.Property(e => e.Ordem)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordem");
            });

            modelBuilder.Entity<ProdutoCodigoBarra>(entity =>
            {
                entity.ToTable("produto_codigo_barra");

                entity.HasComment("tabela com dados dos codigos de barra relacionando com o codigo do produto");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("chave primaria da tabela");

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(255)
                    .HasColumnName("codigo_barra")
                    .HasComment("codigo de barra do produto");

                entity.Property(e => e.CodigoProduto)
                    .HasColumnType("int(11)")
                    .HasColumnName("codigo_produto")
                    .HasComment("referencia do codigo do produto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
