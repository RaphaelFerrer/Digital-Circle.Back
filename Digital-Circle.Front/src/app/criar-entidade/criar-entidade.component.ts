import { Component } from '@angular/core';
import { EntidadeService } from '../entidade.service';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-criar-entidade',
  templateUrl: './criar-entidade.component.html',
  styleUrls: ['./criar-entidade.component.css'],
})
export class CriarEntidadeComponent {
  novoItem: string = '';

  constructor(
    private entidadeService: EntidadeService,
    private dialogRef: MatDialogRef<CriarEntidadeComponent>
  ) {}

  adicionarItem() {
    this.entidadeService
      .incluirRegistro(this.novoItem)
      .subscribe({ next: (result) => {
        this.dialogRef.close();
      } });
  }
}
