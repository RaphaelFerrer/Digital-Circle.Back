import { Component, EventEmitter, OnInit } from '@angular/core';
import { EntidadeService } from './entidade.service';
import { MatDialog } from '@angular/material/dialog';
import { CriarEntidadeComponent } from './criar-entidade/criar-entidade.component';
import { AtualizarEntidadeComponent } from './atualizar-entidade/atualizar-entidade.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'Digital-Circle.Front';

  displayedColumns: string[] = ['id', 'texto', 'data', 'action'];
  dataSource = [];

  constructor(
    private entidadeService: EntidadeService,
    private dialog: MatDialog
  ) {}

  openDialog(): void {
    let dialogRef = this.dialog.open(CriarEntidadeComponent);

    dialogRef.afterClosed().subscribe({
      next: (result) => {
        this.listarRegistros();
      },
    });
  }

  ngOnInit(): void {
    this.listarRegistros();
  }

  listarRegistros() {
    this.entidadeService.getAll().subscribe({
      next: (result) => {
        this.dataSource = result;
      },
    });
  }

  excluirRegistro(id: string): void {
    this.entidadeService.excluirRegistro(id).subscribe({
      next: (result) => {
        this.listarRegistros();
      },
    });
  }

  openDialogAtualizar(registro: any) {
    let dialogRef = this.dialog.open(AtualizarEntidadeComponent, {
      data: registro,
    });

    dialogRef.afterClosed().subscribe({ 
      next: result => {
        this.listarRegistros();
      }
    })
  }
 
}
