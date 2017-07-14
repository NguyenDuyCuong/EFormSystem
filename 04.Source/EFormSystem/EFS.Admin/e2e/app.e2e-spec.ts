import { EFS.AdminPage } from './app.po';

describe('efs.admin App', () => {
  let page: EFS.AdminPage;

  beforeEach(() => {
    page = new EFS.AdminPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
