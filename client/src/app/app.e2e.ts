import { browser, by, element } from 'protractor';
import 'tslib';

describe('App', () => {

  beforeEach(async () => {
    await browser.get('/');
  });

  it('should have a title', async () => {
    let subject = await browser.getTitle();
    let result  = 'Calculator';
    expect(subject).toEqual(result);
  });

  it('should have <header>', async () => {
    let subject = await element(by.css('app header')).isPresent();
    let result  = true;
    expect(subject).toEqual(result);
  });

  it('should have <main>', async () => {
    let subject = await element(by.css('app main')).isPresent();
    let result  = true;
    expect(subject).toEqual(result);
  });

  it('should have main title', async () => {
    let subject = await element(by.css('main h1')).getText();
    let result  = 'Submit Value';
    expect(subject).toEqual(result);
  });
});
