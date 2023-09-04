import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarEntidadeComponent } from './criar-entidade.component';

describe('CriarEntidadeComponent', () => {
  let component: CriarEntidadeComponent;
  let fixture: ComponentFixture<CriarEntidadeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CriarEntidadeComponent]
    });
    fixture = TestBed.createComponent(CriarEntidadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
