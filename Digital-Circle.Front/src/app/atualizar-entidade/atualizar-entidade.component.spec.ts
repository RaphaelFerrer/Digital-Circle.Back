import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AtualizarEntidadeComponent } from './atualizar-entidade.component';

describe('AtualizarEntidadeComponent', () => {
  let component: AtualizarEntidadeComponent;
  let fixture: ComponentFixture<AtualizarEntidadeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AtualizarEntidadeComponent]
    });
    fixture = TestBed.createComponent(AtualizarEntidadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
