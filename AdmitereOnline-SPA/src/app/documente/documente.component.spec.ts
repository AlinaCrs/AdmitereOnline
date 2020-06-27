/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DocumenteComponent } from './documente.component';

describe('DocumenteComponent', () => {
  let component: DocumenteComponent;
  let fixture: ComponentFixture<DocumenteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DocumenteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DocumenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
