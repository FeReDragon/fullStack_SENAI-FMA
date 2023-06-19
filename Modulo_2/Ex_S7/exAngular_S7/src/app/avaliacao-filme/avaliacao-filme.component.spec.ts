import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AvaliacaoFilmeComponent } from './avaliacao-filme.component';

describe('AvaliacaoFilmeComponent', () => {
  let component: AvaliacaoFilmeComponent;
  let fixture: ComponentFixture<AvaliacaoFilmeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AvaliacaoFilmeComponent]
    });
    fixture = TestBed.createComponent(AvaliacaoFilmeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
