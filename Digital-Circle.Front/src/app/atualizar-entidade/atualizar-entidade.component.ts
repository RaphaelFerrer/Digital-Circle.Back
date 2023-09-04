import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { EntidadeService } from '../entidade.service';

@Component({
  selector: 'app-atualizar-entidade',
  templateUrl: './atualizar-entidade.component.html',
  styleUrls: ['./atualizar-entidade.component.css']
})
export class AtualizarEntidadeComponent implements OnInit {
  item: string = '';

  constructor(
    private entidadeService: EntidadeService,
    private dialogRef: MatDialogRef<AtualizarEntidadeComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  ngOnInit(): void {
    this.item = this.data.texto;
  }

  atualizarItem(){
    this.entidadeService.atualizarRegistro({
      id: this.data.id,
      texto: this.item
    }).subscribe({
      next: result => {
        this.dialogRef.close();
      }
    })
  }
}
